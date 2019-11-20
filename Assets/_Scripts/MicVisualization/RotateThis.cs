using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {
    public AudioPeer _audioPeer;
	public Vector3 _rotateAmount;
	//public AudioPeer _audioPeer;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (_rotateAmount.x * _audioPeer._AmplitudeBuffer * Time.deltaTime, _rotateAmount.y * _audioPeer._AmplitudeBuffer * Time.deltaTime, _rotateAmount.z * _audioPeer._AmplitudeBuffer * Time.deltaTime);
	}
}
