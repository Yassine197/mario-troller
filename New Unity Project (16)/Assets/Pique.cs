using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pique : MonoBehaviour {
    public GameObject g;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
            g.GetComponent<SpriteRenderer>().enabled = true;
        
        Debug.Log("collision");
    }

}




