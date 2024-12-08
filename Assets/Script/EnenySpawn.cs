using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenySpawn : MonoBehaviour
{
    public GameObject EnemyPreFab;
    float EnemyRate = 5f;
    float nextEnemy = 1f;
    float SpawnDistance = 20f;
    // Using to spawn the enemy
    void Spawn(){
        Vector3 offset = Random.onUnitSphere;
        offset.z = 0;
        offset = offset.normalized * SpawnDistance;
        Instantiate(EnemyPreFab, transform.position + offset, Quaternion.identity);
    }
    void Update()
    {
    
        nextEnemy -= Time.deltaTime;
        if(nextEnemy <= 0){
            nextEnemy = EnemyRate;
            Spawn();
        }
    }
}
