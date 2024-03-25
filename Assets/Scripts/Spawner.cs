using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;

    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
