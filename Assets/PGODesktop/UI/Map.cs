using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using RestSharp;
using SimpleCoroutines;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PGODesktop.UI
{
    public class Map : UIBehaviour
    {
        private const double TileSize = 256f;
        private const double EarthRadius = 6378137.0;
        public RectTransform ContentRectTransform;
        public RectTransform PlayerArrowTransform;
        public Texture LoadingTexture;
        private IRestClient _restClient;
        private IDictionary<string, Texture> _textures;
        private RectTransform _transform;
        private double _longitude, _latitude;
        private bool _regenerateArea;
        private GameObject[,] _objects;
        private int[,,] _tiles;
        private string[,] _currentTextures;
        private int _gridWidth, _gridHeight;
        private int _centerX, _centerY;
        private int _halfWidth, _halfHeight;
        private int _zoom;
        private int _mapSize;

        protected override void Awake()
        {
            _textures = new Dictionary<string, Texture>();
            _transform = GetComponent<RectTransform>();
            _restClient = new RestClient("http://a.tile.openstreetmap.org/");
            MarkForRegeneration();
            SetPosition(-0.1278f, 51.5074f);
            SetZoom(17);
        }

        public void SetZoom(int level)
        {
            _zoom = level.Bound(0, 19);
            _mapSize = 1 << _zoom;
            _centerX = _longitude.ToTileX(_zoom).FloorToInt();
            _centerY = _latitude.ToTileY(_zoom).FloorToInt();
        }

        public void SetPosition(float longitude, float latitude)
        {
            _longitude = longitude;
            _latitude = latitude;
        }

        public void MarkForRegeneration()
        {
            _regenerateArea = true;
        }

        private void Update()
        {
            Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            if (input.magnitude > 1f)
            {
                input = input.normalized;
            }
            float distance = Vector2.Distance(Vector2.zero, input);
            float angle = Vector2.Angle(Vector2.up, input);
            if (input.x < 0)
            {
                angle = -angle;
            }

            if (distance > 0.1d)
            {
                PlayerArrowTransform.rotation = Quaternion.Euler(0, 0, -angle);
            }
            
            double latRads = _latitude.ToRadians();
            double lonRads = _longitude.ToRadians();
            double angularDistance = (10d*distance*Time.deltaTime)/EarthRadius;
            double angleRads = ((double) angle).ToRadians();

            double lat = Math.Asin(
                Math.Sin(latRads)*Math.Cos(angularDistance) +
                Math.Cos(latRads)*Math.Sin(angularDistance)*Math.Cos(angleRads));

            double lon = ((lonRads + (Math.Atan2(
                Math.Sin(angleRads)*Math.Sin(angularDistance)*Math.Cos(latRads),
                Math.Cos(angularDistance) - Math.Sin(latRads)*Math.Sin(lat))) + Math.PI)%Utils.TwoPi) - Math.PI;

            _latitude = lat.ToDegrees();
            _longitude = lon.ToDegrees();

            if (Input.GetKeyDown(KeyCode.R))
            {
                SetZoom(_zoom + 1);
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                SetZoom(_zoom - 1);
            }

            double offsetX = _longitude.ToTileX(_zoom) - (_centerX + 0.5d);
            double offsetY = _latitude.ToTileY(_zoom) - (_centerY + 0.5d);

            if (offsetX.Abs() > 1d)
            {
                int change = offsetX.MinInt();
                _centerX += change;
                offsetX -= change;
            }

            if (offsetY.Abs() > 1d)
            {
                int change = offsetY.MinInt();
                _centerY += change;
                offsetY -= change;
            }

            ContentRectTransform.localPosition = new Vector3((float) (-offsetX*TileSize).Round(0),
                (float) (offsetY*TileSize).Round(0), 0);

            if (_regenerateArea)
            {
                _regenerateArea = false;
                if (_objects != null)
                {
                    foreach (GameObject go in _objects)
                    {
                        Destroy(go);
                    }
                }

                _halfHeight = (_transform.rect.height/TileSize/2d).CeilToInt() + 1;
                _halfWidth = (_transform.rect.width/TileSize/2d).CeilToInt() + 1;
                _gridHeight = _halfHeight*2 + 1;
                _gridWidth = _halfWidth*2 + 1;
                _objects = new GameObject[_gridWidth, _gridHeight];
                _tiles = new int[_gridWidth, _gridHeight, 3];
                _currentTextures = new string[_gridWidth, _gridHeight];

                for (int x = 0; x < _gridWidth; x++)
                {
                    for (int y = 0; y < _gridHeight; y++)
                    {
                        GameObject go = new GameObject();
                        RectTransform transform = go.AddComponent<RectTransform>();
                        transform.SetParent(ContentRectTransform, false);
                        transform.localScale = new Vector3(1, 1, 1);
                        transform.anchorMax = new Vector2(0.5f, 0.5f);
                        transform.anchorMin = new Vector2(0.5f, 0.5f);
                        transform.sizeDelta = new Vector2((float) TileSize, (float) TileSize);
                        transform.localPosition = new Vector3((float) ((-_halfWidth + x)*TileSize),
                            (float) ((_halfHeight - y)*TileSize), 0);
                        transform.name = "Cell_" + x + "_" + y;
                        _objects[x, y] = go;
                    }
                }
            }


            if (_objects != null)
            {
                for (int x = 0; x < _gridWidth; x++)
                {
                    for (int y = 0; y < _gridHeight; y++)
                    {
                        int rx = _centerX + (-_halfWidth + x);
                        int ry = _centerY + (-_halfHeight + y);
                        string key = _zoom + "/" + rx.Wrap(_mapSize) + "/" + ry.Wrap(_mapSize);

                        if (_currentTextures[x, y] != key)
                        {
                            if (_textures.ContainsKey(key))
                            {
                                _objects[x, y].GetOrAddComponent<RawImage>().texture = _textures[key];
                                _currentTextures[x, y] = key;
                            }
                            else
                            {
                                _objects[x, y].GetOrAddComponent<RawImage>().texture = LoadingTexture;

                                if (_tiles[x, y, 0] != rx || _tiles[x, y, 1] != ry || _tiles[x, y, 2] != _zoom)
                                {
                                    _tiles[x, y, 0] = rx;
                                    _tiles[x, y, 1] = ry;
                                    _tiles[x, y, 2] = _zoom;
                                    CoroutineManager.Start("load_" + UnityEngine.Random.value,
                                        LoadTile(key));
                                }
                            }
                        }
                    }
                }
            }
        }

        private IEnumerator LoadTile(string key)
        {
            yield return new EnterBackground();

            IRestResponse response = _restClient.Execute(new RestRequest(key + ".png", Method.GET));

            yield return new EnterForeground();

            Texture2D texture2D = new Texture2D(256, 256, TextureFormat.ARGB32, false);
            texture2D.LoadImage(response.RawBytes);
            _textures[key] = texture2D;
        }

        protected override void OnRectTransformDimensionsChange()
        {
            _regenerateArea = true;
        }
    }
}