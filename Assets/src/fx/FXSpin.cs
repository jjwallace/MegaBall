using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpin : MonoBehaviour 
{
	public float speed = 90f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}
}