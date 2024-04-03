using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This class manages the spawning of objects in the game
public class EnemySpawner : MonoBehaviour
{

    // This variable holds the prefab you want to spawn. Assign it in the Unity Editor.
    public GameObject objectToSpawn;

    // This is the place in the world where you want to spawn the object. Assign it in Unity Editor.
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
    }
    public void SpawnObject()
    { 
        // Calls the function to spawn the object when the game starts SpawnObject();
        // This function creates an instance of the object at the spawn point public void SpawnObject()
    
        // Instantiate is a Unity function that clones the object at the given position and rotation
        Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}