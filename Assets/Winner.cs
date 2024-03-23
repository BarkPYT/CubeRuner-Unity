using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{

    void OnCollisionEnter (UnityEngine.Collision collision)
    {
    if(collision.collider.tag == "win")
        {
            SceneManager.LoadScene("2lvl");
        }

    }


}
