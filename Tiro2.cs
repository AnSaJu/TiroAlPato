using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro2 : MonoBehaviour
{
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
