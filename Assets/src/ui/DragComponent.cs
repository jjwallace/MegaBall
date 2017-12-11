using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]

public class DragComponent : MonoBehaviour {
  
  [Header("Can be dragged by player?")]
  [Tooltip("Disable from player being able to drag?")]
  private bool canBeDragged = true;
  
  private Vector3 screenPoint;
  private Vector3 offset;

  void OnMouseDown() {
    offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    
    Debug.Log("Start Drag of: " + transform.name);
  }

  void OnMouseDrag()
  {
    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    transform.position = curPosition;
  }
}