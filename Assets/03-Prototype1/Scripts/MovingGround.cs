using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{

    // Speed at which the Moving Ground moves
    public float speed = 2f;

    // Distance where Moving Ground turns around
    public float leftEdge = .5f;

    public float rightEdge = -10f;



    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position; // Current position of the platform
        pos.z += speed * Time.deltaTime; // Makes movement of tree time based
        transform.position = pos; // It is the variable of position in the transform tab

        // Changing Direction
        if (pos.z > leftEdge)
        {
            speed = Mathf.Abs(speed);
        }
        if (pos.z < rightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

}