using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    
    public int health = 5;
    void OnTriggerEnter2D() {
        health--;
    }
    void Update(){
        if(health <= 0){
            Destroy(gameObject);
        }
    }
    
}
