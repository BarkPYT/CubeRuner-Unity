using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollwall : MonoBehaviour
{
    public GameObject obj;
    public float speed = 5f;

    void OnCollisionEnter (UnityEngine.Collision collision)
    {
    if(collision.collider.tag == "Trollwalls")
        {
            obj.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

    }
}
