using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    public GameObject shootingPoing;

    

// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = ObjectPool.SharedInstance.GetFirstPoolObject();
            bullet.layer = LayerMask.NameToLayer("Player Bullet");
            bullet.transform.position = shootingPoing.transform.position;
            bullet.transform.rotation = shootingPoing.transform.rotation;
            bullet.SetActive(true);
            //Destroy(bullet, 2); //TODO: Mejorar mañana
        }
    }
}
