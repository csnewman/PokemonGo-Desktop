using System;
using System.Collections.Generic;
using Google.Protobuf;
using POGOProtos.Networking.Envelopes;
using POGOProtos.Networking.Requests;
using RestSharp;
using UnityEngine;
using Random = System.Random;

namespace PGODesktop
{
    public static class Utils
    {
        public const double TwoPi = Math.PI*2;

        public static string GetHeader(this IRestResponse response, string name)
        {
            String value = null;
            foreach (Parameter param in response.Headers)
            {
                if (param.Name.ToLower() == name.ToLower())
                {
                    value = param.Value.ToString();
                }
            }
            return value;
        }

        public static string GetQuerySection(this string url)
        {
            if (url.Contains("?"))
            {
                return url.Split('?')[1];
            }
            return "";
        }

        //Bassed off of https://github.com/restsharp/RestSharp/blob/80c1e49f322eebd19519fd79b7dd4c497c469a6e/RestSharp/Authenticators/OAuth/Extensions/StringExtensions.cs
        public static IDictionary<string, string> ParseQueryString(this string query, bool lowercaseKeys)
        {
            if (query == null)
            {
                return new Dictionary<string, string>();
            }

            if (query.StartsWith("?"))
            {
                query = query.Substring(1);
            }

            query = query.Trim();

            if (query.Length == 0)
            {
                return new Dictionary<string, string>();
            }

            Dictionary<string, string> data = new Dictionary<string, string>();
            string[] parts = query.Split('&');
            foreach (string part in parts)
            {
                string[] bits = part.Split('=');
                string key = bits[0].Trim();
                if (lowercaseKeys)
                {
                    key = key.ToLower();
                }
                data.Add(key, bits[1].Trim());
            }
            return data;
        }

        public static ulong NextULong(this Random random)
        {
            byte[] bytes = new byte[8];
            random.NextBytes(bytes);
            return BitConverter.ToUInt64(bytes, 0);
        }

        public static ulong FloatToULong(double value)
        {
            return BitConverter.ToUInt64(BitConverter.GetBytes(value), 0);
        }

        public static Request CreateRequest(RequestType type, IMessage message)
        {
            return new Request()
            {
                RequestType = type,
                RequestMessage = message.ToByteString()
            };
        }

        public static T Get<T>(this ResponseEnvelope envelope, int index) where T : IMessage, new()
        {
            T t = new T();
            t.MergeFrom(envelope.Returns[index]);
            return t;
        }

        public static double ToRadians(this double val)
        {
            return 0.0174532925199433D*val;
        }

        public static double ToDegrees(this double val)
        {
            return val*57.2957795130823D;
        }

        public static float ToTileX(this float val, int zoom)
        {
            return (float) ((val + 180.0d)/360.0d*(1 << zoom));
        }

        public static double ToTileX(this double val, int zoom)
        {
            return (val + 180.0d)/360.0d*(1 << zoom);
        }

        public static float ToTileY(this float val, int zoom)
        {
            return (float) ((1.0d - Math.Log(Math.Tan(val*Math.PI/180.0d) +
                                             1.0d/Math.Cos(val*Math.PI/180.0d))/Math.PI)/2.0d*(1 << zoom));
        }

        public static double ToTileY(this double val, int zoom)
        {
            return (1.0d - Math.Log(Math.Tan(val*Math.PI/180.0d) +
                                    1.0d/Math.Cos(val*Math.PI/180.0d))/Math.PI)/2.0d*(1 << zoom);
        }

        public static float ToLongitude(this float val, int zoom)
        {
            return (float) ((val/Math.Pow(2.0, zoom)*360.0) - 180.0);
        }

        public static float ToLatitude(this float val, int zoom)
        {
            double n = Math.PI - ((2.0*Math.PI*val)/Math.Pow(2.0, zoom));
            return (float) (180.0/Math.PI*Math.Atan(Math.Sinh(n)));
        }

        public static int FloorToInt(this float val)
        {
            return Mathf.FloorToInt(val);
        }

        public static int FloorToInt(this double val)
        {
            return (int) Math.Floor(val);
        }

        public static int CeilToInt(this float val)
        {
            return Mathf.CeilToInt(val);
        }

        public static int CeilToInt(this double val)
        {
            return (int) Math.Ceiling(val);
        }

        public static float Abs(this float val)
        {
            return Mathf.Abs(val);
        }

        public static double Abs(this double val)
        {
            return Math.Abs(val);
        }

        public static int MinInt(this float val)
        {
            return val < 0 ? val.CeilToInt() : val.FloorToInt();
        }

        public static int MinInt(this double val)
        {
            return val < 0 ? val.CeilToInt() : val.FloorToInt();
        }

        public static T GetOrAddComponent<T>(this GameObject go) where T : Component
        {
            T t = go.GetComponent<T>();
            if (t != null)
            {
                return t;
            }
            return go.AddComponent<T>();
        }

        public static int Bound(this int val, int min, int max)
        {
            if (val < min)
            {
                val = min;
            }

            if (val > max)
            {
                val = max;
            }

            return val;
        }

        public static int Pos(this int val)
        {
            if (val < 0)
                return -val;
            return val;
        }

        public static int Wrap(this int val, int range)
        {
            val %= range;
            return val < 0 ? range + val : val;
        }

        public static double Round(this double val, int points)
        {
            return Math.Round(val, points, MidpointRounding.AwayFromZero);
        }
    }
}