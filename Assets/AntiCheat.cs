using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiCheat : MonoBehaviour
{
    public Rigidbody rb;
    public float strange = 1f;

    void OnCollisionEnter (UnityEngine.Collision collision)
    {
    if(collision.collider.tag == "CheatWall")
        {
            rb.AddForce(Vector3.left * strange, ForceMode.Impulse);
            rb.AddForce(Vector3.forward * strange, ForceMode.Impulse);
            Debug.Log("Colision!!");
        }
    if(collision.collider.tag == "CheatWall1")
        {
            rb.AddForce(Vector3.right * strange, ForceMode.Impulse);
            rb.AddForce(Vector3.forward * strange, ForceMode.Impulse);
            Debug.Log("Colision!!");
        }
    }
}
