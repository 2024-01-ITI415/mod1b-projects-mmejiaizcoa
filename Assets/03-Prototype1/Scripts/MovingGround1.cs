using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    [Header("Set in Inspector")]

    public float speed = 5.0f;
    public float distance = 10.0f; // The distance it will move back and forth

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position; // Storing the starting position
    }

    void Update()
    {
        Vector3 newPosition = startPosition; // Start at the initial position

        newPosition.z = startPosition.z + Mathf.PingPong(Time.time * speed, distance); // Use Mathf.PingPong to move between 0 and the input distance over time

        transform.position = newPosition; // Updating the position of the platform
    }
}