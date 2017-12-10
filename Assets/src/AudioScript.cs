using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

  public AudioClip audioClip;
  public AudioSource audioSource;
  
	// sound initialization
	void Start () {
		audioSource.clip = audioClip;
	}

  void OnTriggerEnter2D (Collider2D col)
  {
    if(col.gameObject.name == "ball_green")
    {
      audioSource.Play();
    }
  }
}
