using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosión : MonoBehaviour
{
    public float destroyBullet = 0.5f; 

    void Start()
    {        
        Destroy(this.gameObject, destroyBullet);
    }
}
