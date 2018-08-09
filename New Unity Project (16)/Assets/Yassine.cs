using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yassine : MonoBehaviour
{


    Rigidbody2D rb2d;
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    public float gravity = 10.0f;
    private Vector3 motion = Vector3.zero;
    public float delay = 20f;
    private float movementSpeed;
    public bool grounded;
    bool touch;
    public float jump;
    public Collider2D groundCheck;
    Animator anim;
    public LayerMask ground;
    public bool isDead;
    public GameObject ReplayButton;
    Vector2 leftScale;
    Vector2 scale;
    
    //Animation anim;
    private void Start()
    {
        Time.timeScale = 0;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
        anim = GetComponent<Animator>();
        // Set Scale and left scale Vectors
        scale = transform.localScale;

        //Calculate the inverse scale
        leftScale = scale;
        leftScale.x = -scale.x;
    }
 
    void Update() {
        if (isDead)
            return;
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
        }
        grounded = groundCheck.IsTouchingLayers(ground);
        GetComponent<Animator>().SetBool("Grounded", grounded);
        // Get Horizontal Input
        float h = Input.GetAxisRaw("Horizontal");

        // Set Velocity (movement direction * speed)
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * speed, GetComponent<Rigidbody2D>().velocity.y);
        
        if(h<0 || h > 0)
        {
            GetComponent<Animator>().SetBool("isRunning", true);
        }else GetComponent<Animator>().SetBool("isRunning", false);
        Flip(h);
    }
    public void UnFreeze()
    {
        Time.timeScale = 1;
    }

    void Flip(float x)
    {
        if (x < 0)
        {
            transform.localScale = leftScale;
        }
        if (x > 0)
        {
            transform.localScale = scale;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Obstacle")
        {
            speed = 0;
            jump = 0;
            GetComponent<Animator>().SetBool("isDead", true);
            GetComponent<Timer>().enabled = false;
        }
        }
    public void Replay()
    {
        //This line changes the scene to the Scene 0 in your build settings
        SceneManager.LoadScene(0);
    }



}















