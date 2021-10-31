using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menuinicio : MonoBehaviour
{


    
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(2);
    }

    public void MenuInicio()
    {
        SceneManager.LoadScene(0);
    }

   
}
