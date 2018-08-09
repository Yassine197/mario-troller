using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform YassineTransform;
    Vector3 range;

    void Awake()
    {
        //Calculate the range between the Camera's position and the Yassine's position
        range = transform.position - YassineTransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make the Camera follow  Yassine's movement on the X axis
        //And keep the y position constant
        transform.position = new Vector3(range.x + YassineTransform.position.x, transform.position.y, range.z + YassineTransform.position.z);
    }
}


