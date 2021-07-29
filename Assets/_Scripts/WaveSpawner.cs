using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [Tooltip("Prefabs de Enemigo a generar")]
    public GameObject prefab;

    [Tooltip("Tiempo en el que se inicia y finaliza la oleada")] 
    public float startTime, endTime;
    
    [Tooltip("Tiempo entre la generación de enemigos")]
    public float spawnRate;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    void SpawnEnemy()
    {
        Quaternion q = Quaternion.Euler(0,transform.rotation.eulerAngles.y + Random.Range(-45.0f,45.0f), 0);
        Instantiate(prefab, transform.position, q);
    }
}
