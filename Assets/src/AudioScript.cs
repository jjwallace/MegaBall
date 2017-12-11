using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
  
  [Header("*Required Audio Source with AudioClip Attached!")]
  public AudioSource audio;
  
	//sound initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}

  //play when gameObject with 'Ball' tag collides
  void OnTriggerEnter2D (Collider2D col){
    audio.Play();
  }
}
