using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public void lose()
    {
        transform.position = player.position + offset;
    }



}
