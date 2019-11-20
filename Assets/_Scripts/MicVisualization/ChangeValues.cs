using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeValues : MonoBehaviour {
    public CircleTangents _circleTangents;
    public InputPlayer _inputPlayer;
    Slider _slider;
    public float _startValue;
	// Use this for initialization
	void Start () {
        _slider = GetComponent<Slider>();
        _slider.value = _startValue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SliderTreshold()
    {
        _circleTangents._treshold = _slider.value;
        
    }
    public void SliderDiffuseMultiplier()
    {
        _circleTangents._diffuseColorMultiplier = _slider.value;

    }
    public void SliderEmissionMultiplier()
    {
        _circleTangents._emissionColorMultiplier = _slider.value;

    }
    public void SliderSphereTransparency()
    {
        _circleTangents._transparency = _slider.value;

    }
    public void SliderInnerCircleScale()
    {
        _inputPlayer._scale = _slider.value;

    }
}
