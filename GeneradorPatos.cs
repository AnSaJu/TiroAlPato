using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPatos : MonoBehaviour
{
    public float tiempoEspera;
    public GameObject[] patos;
    public Transform[] puntoSpawn;

    private float tiempoParaSpawn = 0f;

    void Update()
    {
        if(tiempoParaSpawn <= Time.time)
        {
            GeneradorPato();
            tiempoParaSpawn = Time.time + tiempoEspera;
        }
    }

    void GeneradorPato()
    {
        int randomIndex = Random.Range(0, puntoSpawn.Length);
        Transform puntonSpawn = puntoSpawn[randomIndex];

        int randomPatos = Random.Range(0, patos.Length);
        Instantiate(patos[randomPatos], puntonSpawn.position, puntonSpawn.rotation);
    }
}
