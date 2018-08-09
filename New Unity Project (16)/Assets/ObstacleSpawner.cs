using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float distance;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            //Choose random Y position
            float obstacleY = Random.Range(minX, maxX);
            //Choose a position for the new obstacle
            Vector3 spawnPosition = new Vector3(transform.position.x + obstacleY + distance,  col.transform.position.y);
            // Move Obstacle to SpawnPosition
            col.gameObject.transform.position = spawnPosition;

        }
    }
}
