using UnityEngine;
using System.Collections;

public class ForceSpring : MonoBehaviour
{
  
  private Animator anim;
  public float bounceStrength = 10f;
  public Rigidbody2D rb;
  
  void Start (){
    //set animation reference
    anim = GetComponent<Animator>();
  }
  
  void OnTriggerEnter2D (Collider2D col)
  {
    
    if(col.gameObject.name == "ball_green")
    {
      //Play Animation
      anim.Play("bounceAnimation");
      
      //reference rigid body of collision object (ball)
      rb = col.gameObject.GetComponent<Rigidbody2D>();
   
      //zero out collision object (ball) velocity
      rb.velocity = Vector3.zero;
      
      //add force to collision object (ball)
      rb.AddForce(transform.up * bounceStrength * -50);

    }
  }
}