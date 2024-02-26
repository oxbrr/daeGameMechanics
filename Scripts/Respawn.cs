using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;

    public GameObject playerPrefab;

    public void RespawnPlayer()
    {
        if (playerPrefab && respawnPoint)
        {
            Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        }
    }
}
