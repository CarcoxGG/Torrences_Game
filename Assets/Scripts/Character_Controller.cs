using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character_Controller : MonoBehaviour
{
    private RaycastHit2D hit;
    private BoxCollider2D boxCollider;
    public float speed = 4f;

    

    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;
    // Start is called before the first frame update
    void Start(){
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update(){
        mov = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        anim.SetFloat("movX", mov.x);
        anim.SetFloat("movY", mov.y);
    }
    private void FixedUpdate(){
        
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0,mov.y),Mathf.Abs(mov.y * Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));

        if (hit.collider == null)
        {
            transform.Translate(0, mov.y * Time.deltaTime, 0);
        }


        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(mov.x, 0), Mathf.Abs(mov.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            transform.Translate(0, mov.x * Time.deltaTime, 0, 0);
        }
    }
}
