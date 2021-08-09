using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    
    public GameObject shootingPoing;

    private Animator _animator;

    public int bulletsAmount;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _animator.SetTrigger("Shot Bullet");

            if (bulletsAmount > 0)
            {
                Invoke("FireBullet", 0.25f);
            }
        }
    }

    void FireBullet()
    {
        GameObject bullet = ObjectPool.SharedInstance.GetFirstPoolObject();
        bullet.layer = LayerMask.NameToLayer("Player Bullet");
        bullet.transform.position = shootingPoing.transform.position;
        bullet.transform.rotation = shootingPoing.transform.rotation;
        bullet.SetActive(true);
        
        bulletsAmount--;
        //Destroy(bullet, 2); //TODO: Mejorar mañana
    }
}
