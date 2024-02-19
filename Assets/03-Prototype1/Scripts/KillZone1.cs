using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone1 : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint1;

    // This method is automatically called when a collision occurs
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Reset the player's position to the respawn point
            player.transform.position = respawnPoint1.position;
        }
    }
}