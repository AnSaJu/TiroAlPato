using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnElBlanco : MonoBehaviour
{
    
    public GameObject tiro;
    public SpriteRenderer spPato;
    public Sprite spPatoGris;
    public Sprite spPatoAma;   
    public AudioSource sonidoDisparo;
    
    
    private Vector3 posicionTiro;

    float i;
    float ii;
    float iii;

    bool enJuego = true;

    void Awake()
    {
        i = 0;
        ii = 0;
        iii = 0;
        enJuego = true;
        
        sonidoDisparo = GetComponent<AudioSource>();
    }
 

    void OnMouseDown()
    {
        sonidoDisparo.Play();
        if (CompareTag("blanco") && enJuego)
        {

            NumeroTiros.puntos += 1;
            enJuego = false;
            Debug.Log("Disparo");          
            StartCoroutine(CambiarPato());           

        }
        if (CompareTag("blanco"))
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

    IEnumerator CambiarPato()
    {
        while (iii < 0.02)
        {
            while (i < 0.3)
            {
                spPato.sprite = spPatoGris;
                yield return null;
                i += 1 * Time.deltaTime;
            }

            while (ii < 0.3)
            {
                spPato.sprite = spPatoAma;
                yield return null;
                ii += 1 * Time.deltaTime;
            }
            yield return null;
            i = 0;
            ii = 0;
            iii += 1 * Time.deltaTime; 
        }
        spPato.sprite = spPatoGris;
    }
}
