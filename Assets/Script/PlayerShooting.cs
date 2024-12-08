using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    float coolDown = 0;
    public float fireDelay = 0.25f;
    public GameObject bulletprefab;
    
    void Update()
    {
        // fireeee
        // there is a cooldown to fire and it will decrease after time
        coolDown -= Time.deltaTime;

        if(Input.GetButton("Fire1") && coolDown <= 0){
            coolDown = fireDelay;
            //reset cooldown
            // the bullet will apear 0.5f ahead the hit box
            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);
            //creat the bullet
            GameObject BulletGO = (GameObject) Instantiate(bulletprefab, transform.position + offset, transform.rotation);
            //ensure that the bullet create by player can not kill player; the ones create by enemy can not kill them
            BulletGO.layer = gameObject.layer;
        }
    }
}
