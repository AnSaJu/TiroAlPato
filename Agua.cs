using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    public float tiempoDeMovimiento;
    public float velocidad;

    private float siguienteMovimiento;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.time > siguienteMovimiento)
        {
            siguienteMovimiento = Time.time + tiempoDeMovimiento;
            velocidad *= -1;
            rb.velocity = new Vector2(velocidad, 0);
        }
    }
}
