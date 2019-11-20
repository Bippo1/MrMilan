using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowMenu : MonoBehaviour {
    public GameObject _options;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            bool stateOptions = _options.activeSelf;
            _options.SetActive(!stateOptions); 
        }
	}
}
