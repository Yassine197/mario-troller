using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathObstacle")
            // Debug.Log("hello");
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

    }
}
