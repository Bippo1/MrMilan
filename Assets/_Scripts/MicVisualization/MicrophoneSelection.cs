using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicrophoneSelection : MonoBehaviour {
	public AudioPeer _audioPeer;
	public Toggle _toggleUseMicrophone;
	public Dropdown _dropdownSelectMicInput;
	// Use this for initialization
	void Start () {
		if (_audioPeer._useMicrophone) {
			_dropdownSelectMicInput.interactable = true;
		}
		if (!_audioPeer._useMicrophone) {
			_dropdownSelectMicInput.interactable = false;
		}

	}

	// Update is called once per frame
	void Update () {
        if (Microphone.devices.Length == 0 && _toggleUseMicrophone.interactable == true)
        {
            _toggleUseMicrophone.interactable = false;
            _toggleUseMicrophone.isOn = false;
            _audioPeer._useMicrophone = false;

        }
        if (Microphone.devices.Length > 0 && _toggleUseMicrophone.interactable == false)
        {
            _toggleUseMicrophone.interactable = true;

        }


        for (int i = _dropdownSelectMicInput.options.Count; i < Microphone.devices.Length; i++) {
			Dropdown.OptionData _listItem = new Dropdown.OptionData (Microphone.devices [0].ToString ());
			_dropdownSelectMicInput.options.Add (_listItem);
		}
		for (int i = 0; i < Microphone.devices.Length; i++) {
			_dropdownSelectMicInput.options[i] = new Dropdown.OptionData(Microphone.devices [i].ToString ());
		}
		if (_dropdownSelectMicInput.options.Count > Microphone.devices.Length) {
			_dropdownSelectMicInput.options.RemoveAt(0);
		}

		if ((_audioPeer._useMicrophone) && (_dropdownSelectMicInput.interactable == false)) {
			_dropdownSelectMicInput.interactable = true;
		}
		if ((!_audioPeer._useMicrophone) && (_dropdownSelectMicInput.interactable == true)) {
			_dropdownSelectMicInput.interactable = false;
		}
        if ( _toggleUseMicrophone.isOn != _audioPeer._useMicrophone)
        {
            _audioPeer._useMicrophone = _toggleUseMicrophone.isOn;
        }

        if (_audioPeer.selectedDevice != _dropdownSelectMicInput.options[_dropdownSelectMicInput.value].text.ToString())
        {
            _audioPeer.selectedDevice = _dropdownSelectMicInput.options[_dropdownSelectMicInput.value].text.ToString();
        }
	}

	public void ToggleUseMicrophone()
	{
		_audioPeer._useMicrophone = _toggleUseMicrophone.isOn;
		//	AudioPeer.selectedDevice = _dropdownSelectMicInput.options [_dropdownSelectMicInput.value].text.ToString();

	}

	public void SwitchBetweenInput()
	{
		_audioPeer.selectedDevice = _dropdownSelectMicInput.options [_dropdownSelectMicInput.value].text.ToString();


	}
}
