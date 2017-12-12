using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	public GameObject gameManager;
	
	void Awake () {
		if(GameManager.instance == null){
      //launch game manager if not active
      Instantiate(gameManager);
    }
	}
}
