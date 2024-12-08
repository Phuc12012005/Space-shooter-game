using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    
    Transform player;
    void Update()
    {
        //find the player
        if(player == null){
            GameObject go = GameObject.FindWithTag("Player");

            if (go != null){
                player = go.transform;
            }
        }
        // this vector will point to the player
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        //create a angle with x and y from the vector, convert it from radian to degree
        float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        // rotate the enemy ship toward the player 
        Quaternion aim = Quaternion.Euler(0, 0, zAngle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, aim, 90f * Time.deltaTime);
    }
}
