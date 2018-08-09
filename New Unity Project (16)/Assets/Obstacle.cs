using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            GetComponent<Rigidbody2D>().gravityScale = 2;
           // Debug.Log("YOU JUST GOT MARIO TROLLED");
        }

    }
}

