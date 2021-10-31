using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumeroTiros : MonoBehaviour
{
    public static int tiros = 3;
    public static int puntos;
    public Text texPuntos;
    public Text texGameOver;
    public GameObject[] disparos;

    public AudioSource sonidoDisparo;

    private int puntosGanados;
    private int tirosPerdidos;
    private int aray = 0;

    void Awake()
    {
        puntos = 00;
        puntosGanados = 00;
        tirosPerdidos = 2;
        sonidoDisparo = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (tiros <= tirosPerdidos && tiros >= 0)
        {

            disparos[aray].SetActive(false);
            aray++;
            tirosPerdidos--;
        }

        if (puntos >= puntosGanados && tiros > 0)
        {
            texPuntos.text = "Patos: " + puntos;
            puntosGanados += 1;
            Puntaje.tuPuntaje = puntos;
        }


        if (tiros == 0 )
        {
           
           
            texGameOver.enabled = true;
            Invoke("CargarScena", 3f);
        }

       
        
    }

    void OnMouseDown()
    {
        sonidoDisparo.Play();
        tiros--;
    }

    void CargarScena()
    {
        SceneManager.LoadScene(0);
        tiros = 3;
    }
  
}
