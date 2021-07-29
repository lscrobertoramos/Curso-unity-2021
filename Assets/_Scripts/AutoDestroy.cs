using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float destructionDelay;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,destructionDelay);
        Invoke("HideObject", destructionDelay);
    }

    void HideObject()
    {
        gameObject.SetActive(false);
    }
}
