using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Lose ls; 
    public GameManager gm;
    public Rigidbody rb;
    public float runspeed = 500f;
    public float strafespeed = 500f;
    public float jumpforce = 15f;
    public float DoJump = 1;

    protected bool strafeleft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;
    protected bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter (UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
            {

                //ls.lose();

                gm.EndGame();
                Debug.Log("PURPLE IS SUS");
            }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > DoJump)
        {
            canJump = false;
        }
        else
        {
            canJump = true;
        }

        if(Input.GetKey("a"))
        {
            strafeleft = true;
        }
        else
        {
            strafeleft = false;
        }
        if(Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight = false;
        }
        if(Input.GetKeyDown("space"))
        {
            doJump = true;
        }
        if(transform.position.y < -5f)
        {
            gm.EndGame();
            //ls.lose();


            Debug.Log("RED IS SUS");
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0,0,runspeed * Time.deltaTime);

        if (strafeleft){
            rb.AddForce(-strafespeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (strafeRight){
            rb.AddForce(strafespeed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (doJump & canJump){
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            doJump = false;
        }


    }


}
