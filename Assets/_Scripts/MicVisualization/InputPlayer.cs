using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour {
	public float _scale;
	float _xSmooth, _ySmooth;

	// Use this for initialization
	void Start () {
//		Offsetsmooth=Offsetsmooth*0.97f+Offset.x*0.03f;
//		OffsetsmoothY=OffsetsmoothY*0.93f+Offset.y*0.07f;
//		OffsetsmoothZ=OffsetsmoothZ*0.93f+Offset.z*0.07f;
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.localScale = new Vector3 (_scale, _scale, _scale);
		float x = Input.GetAxis ("Horizontal");

		float y = Input.GetAxis ("Vertical") ;
		_xSmooth = _xSmooth * 0.90f + x * 0.1f;
		_ySmooth = _ySmooth * 0.90f + y * 0.1f;

		this.transform.position = new Vector3 (_xSmooth * (2.5f - (_scale * 0.5f)), this.transform.position.y, -_ySmooth * (2.5f - (_scale * 0.5f)));

	}

}
