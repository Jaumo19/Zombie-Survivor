using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComprarPuertas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI mensajeComprarPuerta;

    [SerializeField] private TextMeshProUGUI dineroActual;

    [SerializeField] private GameObject spawns;
    [SerializeField] private GameObject spawnsSiguiente;
    // Start is called before the first frame update
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        
        mensajeComprarPuerta.enabled = true;
        if (gameObject.name == "Puerta1")
        {
            mensajeComprarPuerta.text = "¿Comprar puerta por 1000$? [E]";
            if (Input.GetKey(KeyCode.E))
            {
                if (int.Parse(dineroActual.text) >= 1000)
                {
                    UIManager.Instance.RestarDinero(1000);
                    gameObject.SetActive(false);
                    DeclararSpawns.Instance.PrimeraPuertaAbierta();
                }
                else
                {
                    Debug.Log("No tienes dinero xd");
                }
            }
        }
        if (gameObject.name == "Puerta2")
        {
            mensajeComprarPuerta.text = "¿Comprar puerta por 2000$? [E]";
            if (Input.GetKey(KeyCode.E))
            {
                if (int.Parse(dineroActual.text) >= 2000)
                {
                    UIManager.Instance.RestarDinero(2000);
                    gameObject.SetActive(false);
                    DeclararSpawns.Instance.SegundaPuertaAbierta();
                }
                else
                {
                    Debug.Log("No tienes dinero xd");
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        mensajeComprarPuerta.enabled = false;
    }
}
