using UnityEngine;
using System.Collections;

public class ForceSpring : MonoBehaviour{
  
  private Animator anim;
  public float bounceStrength = 10f;
  
  //Promt game designer to use 'Ball' tag
  [Header("Automatically set to tag 'Ball'")]
  [Tooltip("This spring force will be applied to any item containing the tag 'Ball' and does not need a rigid body assign to this field.")]
  public Rigidbody2D rb;
  
  private int bounceCount;
  
  void Start (){
    //set animation reference
    anim = GetComponent<Animator>();
  }
  
  void OnTriggerEnter2D (Collider2D col){
    
    if(col.gameObject.tag == "Ball"){
      
      //Play Animation
      anim.Play("bounceAnimation");
      
      //reference rigid body of collision object (ball)
      rb = col.gameObject.GetComponent<Rigidbody2D>();
   
      //zero out collision object (ball) velocity
      rb.velocity = Vector3.zero;
      
      //add force to collision object (ball)
      rb.AddForce(transform.up * bounceStrength * -50);
      
      //log Collision
      bounceCount ++;
      Debug.Log("Spring Bounce on spring: " + transform.name + 
                " - Bounces: " + bounceCount);
    }
  }
}