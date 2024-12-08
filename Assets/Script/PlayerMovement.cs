using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float maxSpeed = 10f;
    float rotSpeed = 200f;
    float shipBoudaryRadius = 1f;
    //Control the player movement
    void Update()
    {
        //rotate the ship
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
         
        //move the ship along the y axis
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        //final position
        pos += rot * velocity;
        
        //Restrict the player from the camera's boundaries
        if(pos.y + shipBoudaryRadius > Camera.main.orthographicSize){
            pos.y = Camera.main.orthographicSize - shipBoudaryRadius;
        }
        if(pos.y - shipBoudaryRadius < -Camera.main.orthographicSize){
            pos.y = -Camera.main.orthographicSize + shipBoudaryRadius;
        }

        float ScreenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * ScreenRatio;

         if(pos.x + shipBoudaryRadius > widthOrtho){
            pos.x = widthOrtho - shipBoudaryRadius;
        }
        if(pos.x - shipBoudaryRadius < -widthOrtho){
            pos.x = -widthOrtho + shipBoudaryRadius;
        }

        transform.position = pos;

    }
}
