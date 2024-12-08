using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    float coolDown = 0;
    public float fireDelay = 0.5f;
    public GameObject bulletprefab;
    Transform player;
    void Update()
    {
        // find the player
        if(player == null){
            GameObject go = GameObject.FindWithTag("Player");

            if (go != null){
                player = go.transform;
            }
        }
        // fireeeee
        coolDown -= Time.deltaTime;
        if(coolDown <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 4){
            coolDown = fireDelay;
            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);
            GameObject BulletGO = (GameObject) Instantiate(bulletprefab, transform.position + offset, transform.rotation);
            BulletGO.layer = gameObject.layer;
        }
    }
}
