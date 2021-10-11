using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Controller : MonoBehaviour
{
   public float speed;
   private Rigidbody2D myRigidbody;
   private Vector3 change;
   private Animator animator;

    void Start(){
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

   
    void Update(){
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();

       
    }

    void UpdateAnimationAndMove()
    {
        if(change != Vector3.zero)
        {
            Movecharacter();
            animator.SetFloat("MoveX", change.x);
            animator.SetFloat("MoveY", change.y);
            animator.SetBool("Move", true);
        }else{
            animator.SetBool("Move", false);
        }

    }
    
    void Movecharacter()
    {
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }
}
