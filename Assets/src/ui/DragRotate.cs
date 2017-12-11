using UnityEngine;
using System.Collections;
 
public class DragRotate : MonoBehaviour {
  
  [Header("Degree of rotation offset. *360")]
  public float offset = 0.0f;
   
  Vector3 startDragDir;
  Vector3 currentDragDir;
  Quaternion initialRotation;
  float angleFromStart;
  
  //declare parent object
  private GameObject myParent;
  
  void Start(){
    //Set parent object two layers up
    myParent = transform.parent.gameObject;
    Debug.Log("Rotation Object Parent: " + myParent);
  }

  void OnMouseDown(){
    //get initial coordinance of object and mouse
    startDragDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - myParent.transform.position;

    //set initial rotation variable
    initialRotation = myParent.transform.rotation;
    Debug.Log("Start Rotate Drag of: " + transform.name);
  } 
  
  void OnMouseDrag(){
    
    //calculate mouse vs object location
    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - myParent.transform.position;
    
    //convert the vector to one plane
    difference.Normalize();

    //trig calculation for radian to degree conversion
    float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

    //set rotation
    myParent.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ - (90 + offset));
  }
}