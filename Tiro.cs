using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tiro : MonoBehaviour
{
    public Rigidbody2D rb;
    public int velocidadMin, velocidadMax;
    public float tiempoCambioMovimiento;
    public int velocidadEnY;

    public AudioSource sonidoDisparo;

    public GameObject tiro;
    public EnElBlanco gris;
    

    private int velocidadBlanco;
    private float tiempoEspera;

    private Vector3 posicionTiro;

   


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sonidoDisparo = GetComponent<AudioSource>();

    }

    void Start()
    {
        velocidadBlanco = Random.Range(velocidadMin, velocidadMax);
    }

    void Update()
    {

        Destroy(gameObject, 9f);
        rb.velocity = new Vector2(velocidadBlanco, rb.velocity.y);

        if (Time.time > tiempoEspera)
        {
            tiempoEspera = Time.time + tiempoCambioMovimiento;
            velocidadEnY *= -1;
            rb.velocity = new Vector2(rb.velocity.x, velocidadEnY);
        }
        
    }

    void OnMouseDown()
    {
        sonidoDisparo.Play();
        NumeroTiros.tiros--;
        if (CompareTag("pato"))
        {
            posicionTiro = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionTiro.z = 0f;
            Instantiate(tiro, posicionTiro, Quaternion.identity);
            
        }     
    
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("tiro"))
        {
            other.transform.SetParent(transform);
        }
        
    
    }
}
