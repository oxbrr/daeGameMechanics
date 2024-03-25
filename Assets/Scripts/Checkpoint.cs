using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 CurrentRespawnPoint;

    void OnTriggerExit2d(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CurrentRespawnPoint = transform.position;
        }
    }
}
