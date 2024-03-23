using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumper : MonoBehaviour
{
    public Rigidbody rb;
    public float strange = 1f;

    void OnCollisionEnter (UnityEngine.Collision collision)
    {
    if(collision.collider.tag == "jumper")
        {
            rb.AddForce(Vector3.up * strange, ForceMode.Impulse);
        }
    }
}
