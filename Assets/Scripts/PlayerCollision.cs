using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("obstacle"))
        {
            playerMovement.enabled = false;
            FindObjectsByType<GameManager>(FindObjectsSortMode.None)[0].EndGame();
        }
    }
}
