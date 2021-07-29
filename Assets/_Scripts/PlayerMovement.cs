using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Searcher;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    // Update is called once per frame
    [Tooltip("Velocidad de Movimiento del personaje en N/seg (Newton por segundo)")]
    [Range (0, 1000)]
    public float speed;
    
    [Tooltip("Velocidad de Rotación del personaje en /seg (Newton por segundo)")]
    [Range (0, 360)]
    public float rotationSpeed;

    private Rigidbody rb;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // S = V*t (Espacio es igual a velocidad por tiempo)
        float space = speed * Time.deltaTime;
        
        float horizontal = Input.GetAxis("Horizontal"); // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1

        Vector3 dir = new Vector3(horizontal, 0, vertical);
        
        //transform.Translate(dir.normalized*space);
        //FUERZA DE TRANSLACIÓN
        rb.AddRelativeForce(dir.normalized*space);

        float angle = rotationSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");
        //transform.Rotate(0, mouseX*angle, 0);
        //FUERZA DE ROTACIÓN
        rb.AddRelativeTorque(0, mouseX*angle, 0);
        
        
        
        
        /*
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,space);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-space);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-space,0,0);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(space,0,0);
        }
        */
    }
}
