using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    void UseVector2()
    {
        Vector2 position = new Vector2(3.0f, 2.0f);
    }

    void UseVector3()
    {
        Vector3 position3D = new Vector3(3.0f, 2.0f, 3.0f);
    }

    void UseStaticProperties()
    {
        Vector3 moveForward = Vector3.forward;
        Vector3 moveUp = Vector3.up;
        Vector3 moveDown = Vector3.down;
        Vector3 moveLeft = Vector3.left;
        Vector3 moveRight = Vector3.right;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
