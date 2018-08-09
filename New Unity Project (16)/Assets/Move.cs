using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            GetComponent<Rigidbody2D>().gravityScale = 2;
    }

}
