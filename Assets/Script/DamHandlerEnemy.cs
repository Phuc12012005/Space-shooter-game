using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamHandlerEnemy : MonoBehaviour
{
    
    public int health = 1;

    void OnTriggerEnter2D() {
        health --;
    }
    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Destroy(gameObject);
        }
    }
}
