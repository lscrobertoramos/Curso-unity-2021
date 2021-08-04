using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager SharedInstance;

    private void Awake()
    {
        if (SharedInstance == null)
        {
            SharedInstance = this;
        }
        else
        {
            Debug.LogWarning("ScoreManager duplicado debe ser destruido");
            Destroy(gameObject);
        }
    }
    [SerializeField]
    [Tooltip("Cantidad de puntos de la partida actual")]
    private int amount;

    public int Amount
    {
        get => amount;
        set => amount = value;
    }
    
    
    
}
