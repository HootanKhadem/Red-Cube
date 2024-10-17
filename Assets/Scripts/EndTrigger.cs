using System;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager GameManager;
    private void OnTriggerEnter(Collider other)
    {
        GameManager.CompleteLevel();
    }
}
