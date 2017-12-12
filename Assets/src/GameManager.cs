using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

  //pause vars
  private bool paused;
  
  public bool pause{
    get { return paused;}
  }
  
  public static GameManager instance = null;
  
  //Create game manager if it does not exist
  void Awake(){
    if(instance == null){
      instance = this; 
    }else if(instance != this){
      Destroy(gameObject);
    }
    DontDestroyOnLoad(gameObject);
  }
  
  //Puase and unPause Game
  public void PauseGame(){
    paused = !paused;
  }
  
}
