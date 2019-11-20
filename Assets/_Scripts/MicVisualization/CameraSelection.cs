using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelection : MonoBehaviour {
    public GameObject _camera1, _camera2, _camera3;

    public void Camera1()
    {
        _camera1.SetActive(true);
      //  _camera2.SetActive(false);
      //  _camera3.SetActive(false);
    }
    /*public void Camera2()
    {
        _camera1.SetActive(false);
      //  _camera2.SetActive(true);
      //  _camera3.SetActive(false);
    }
    public void Camera3()
    {
        _camera1.SetActive(false);
      //  _camera2.SetActive(false);
      //  _camera3.SetActive(true);
    }
    */
}
