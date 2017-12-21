using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

  public List<GameObject> prefabs;        // The prefab to be spawned.
  public float spawnTime = 3f;            // How long between each spawn.
  private Animator anim;
  public AnimationClip animClip;

  void Start(){
    // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
    InvokeRepeating ("StartAnimation", 0, spawnTime);
    
    anim = GetComponent<Animator>();
  }

  private void StartAnimation(){
    //Play Animation of SpawnPoint
    anim.Play("spawnAnimation");
    
    //Wait for Animation to complete then spawn
    StartCoroutine("waitForAnimation");
  }
  
  IEnumerator waitForAnimation(){
    //wait for clip to finish
    yield return new WaitForSeconds(animClip.length-0.4f);
    SpawnPrefab();
  }
  
    
  private void SpawnPrefab() {
    //anim.SetInteger ("spawnAnimation", 3);
    
    Vector3 thisPos = this.transform.position;

    //This will spawn them at (0,0,0) with (0,0,0) rotation
    Instantiate(prefabs[Random.Range(0, prefabs.Count)], thisPos, Quaternion.identity); 

    Debug.Log("Item Spawned: " + this.transform.name);
  }
   
}



