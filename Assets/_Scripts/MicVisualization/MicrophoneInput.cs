﻿using UnityEngine;
 using System.Collections;
 
 [RequireComponent(typeof(AudioSource))]
 public class MicrophoneInput : MonoBehaviour {
  //   public float sensitivity = 100;
  //   public float loudness = 0;
     
     void Start() {
		GetComponent<AudioSource>().clip = Microphone.Start(null, true,1, AudioSettings.outputSampleRate);
         GetComponent<AudioSource>().loop = true; // Set the AudioClip to loop
        // GetComponent<AudioSource>().mute = true; // Mute the sound, we don't want the player to hear it
         while (!(Microphone.GetPosition(null) > 0)){} // Wait until the recording has started
         GetComponent<AudioSource>().Play(); // Play the audio source!
     }
     
     void Update(){
     //    loudness = GetAveragedVolume() * sensitivity;
     }
     
//     float GetAveragedVolume()
//     { 
//         float[] data = new float[256];
//         float a = 0;
//         GetComponent<AudioSource>().GetOutputData(data,0);
//         foreach(float s in data)
//         {
//             a += Mathf.Abs(s);
//         }
//         return a/256;
//     }
     
 }
