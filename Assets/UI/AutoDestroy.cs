using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {
	public float Life;
	private float _created;

	void OnEnable () {
		_created = Time.time;
	}

	public void ResetTime(){
		_created = Time.time;
	}
	
	void Update () {
		if(Time.time - _created > Life){
			gameObject.SetActive (false);
		}
	}
}
