using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer = 5f;
    void Update()
    {
        // self destruct after 5s
        Destroy(gameObject, timer);
    }
}
