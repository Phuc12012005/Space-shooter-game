using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float Speed = 5f;
    // control the bullet movement
    void Update()
    {
        // the bullet can only go forward
        transform.position += transform.rotation * new Vector3(0, Speed*Time.deltaTime, 0);
        
    }
}
