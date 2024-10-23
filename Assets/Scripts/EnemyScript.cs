using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    public Transform[] waypoints;
    private int waypointIndex = 0;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (waypointIndex < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, speed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].position)
            {
                waypointIndex++;
            }
        }
    }
}