using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    [Range (0,100)]
    [Tooltip ("Este campo se utiliza para el dinero del jugador")]
    private float _money;

    public float money
    {
        get => _money;
        
        set
        {
            if (value < 0)
            {
                _money = 0;
            }
            else
            {
                _money = value;
            }
        }
    }

    public bool IsPoor
    {
        get => money < 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        if (true)
        {
            Debug.Log("mensaje");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
