using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllUI : MonoBehaviour
{
    public DamageHandler player;
    int HP;
    
    void Update()
    {
        HP = player.health;
        
    }
}
