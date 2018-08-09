using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRock : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Yassine").SendMessage("Finish");
    }
}

