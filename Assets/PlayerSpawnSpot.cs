using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawnSpot : MonoBehaviour
{
    public GameObject playerPreFab;
    //This program is used to spawn player
    // Each time the player spawn, life--
    void SpawnPlayer(){
        Instantiate(playerPreFab, transform.position, Quaternion.identity);
    }
    void Start()
    {
        SpawnPlayer();
    }
}
