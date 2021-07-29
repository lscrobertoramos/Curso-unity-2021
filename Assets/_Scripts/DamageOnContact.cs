using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public float damage;
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);//Desactiva la bala
        
        /*if (other.CompareTag("Enemy") || other.CompareTag("Player"))
        {
            Destroy(other.gameObject);//Destruye el otro objeto
        }*/
        Life life = other.GetComponent<Life>();
        if (life != null)
        {
            life.Amount -= damage;
        }
    
        Debug.Log("Entro");


    }
}
