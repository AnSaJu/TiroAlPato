using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estaca : MonoBehaviour
{
    SpriteRenderer spR;
    public int layerEstaca = -1;

    void Awake()
    {
        spR = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("spawn2"))
        {
            
                spR.sortingOrder = layerEstaca;
        }

    }

    public Collider2D colli;

    void Update()
    {
        Invoke("Avi", 0.5f);

    }

    void Avi()
    {
        colli.enabled = false;
    }
}
