using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public Text texTuPuntaje;
    public Text texMejorPuntaje;
    public static int mejorPuntaje;
    public static int tuPuntaje = 0;

    void Start()
    {

        texTuPuntaje.text = tuPuntaje.ToString();

        if (tuPuntaje > mejorPuntaje)
        {
            texMejorPuntaje.text = tuPuntaje.ToString();
            mejorPuntaje = tuPuntaje;
        }
        else
        {
            texMejorPuntaje.text = mejorPuntaje.ToString();
        }
    }
}
