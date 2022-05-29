using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComprarPuertas : MonoBehaviour
{
    [SerializeField] private GameObject comprarPuerta;
    [SerializeField] private TextMeshProUGUI mensajeComprarPuerta;

    [SerializeField] private TextMeshProUGUI dineroActual;
    
    // Start is called before the first frame update
    
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            comprarPuerta.SetActive(true);
            mensajeComprarPuerta.enabled = true;
            if (gameObject.name == "Puerta1")
            {
                mensajeComprarPuerta.text = "¿Comprar puerta por 2500$? [E]";
                if (Input.GetKey(KeyCode.E))
                {
                    if (int.Parse(dineroActual.text) >= 2500)
                    {
                        UIManager.Instance.RestarDinero(2500);
                        gameObject.SetActive(false);
                        DeclararSpawns.Instance.PrimeraPuertaAbierta();
                    }
                }
            }
            else if (gameObject.name == "Puerta2")
            {
                mensajeComprarPuerta.text = "¿Comprar puerta por 4500$? [E]";
                if (Input.GetKey(KeyCode.E))
                {
                    if (int.Parse(dineroActual.text) >= 4500)
                    {
                        UIManager.Instance.RestarDinero(4500);
                        gameObject.SetActive(false);
                        DeclararSpawns.Instance.SegundaPuertaAbierta();
                    }
                }
            }
            else if (gameObject.name == "Puerta3")
            {
                mensajeComprarPuerta.text = "¿Comprar puerta por 6000$? [E]";
                if (Input.GetKey(KeyCode.E))
                {
                    if (int.Parse(dineroActual.text) >= 6000)
                    {
                        UIManager.Instance.RestarDinero(6000);
                        gameObject.SetActive(false);
                        DeclararSpawns.Instance.TerceraPuertaAbierta();
                    }
                }
            }
            else if (gameObject.name == "Puerta4")
            {
                mensajeComprarPuerta.text = "¿Comprar puerta por 7000$? [E]";
                if (Input.GetKey(KeyCode.E))
                {
                    if (int.Parse(dineroActual.text) >= 7000)
                    {
                        UIManager.Instance.RestarDinero(7000);
                        gameObject.SetActive(false);
                        DeclararSpawns.Instance.CuartaPuertaAbierta();
                    }
                    else
                    {
                        Debug.Log("No tienes dinero xd");
                    }
                }
            }
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        mensajeComprarPuerta.enabled = false;
        comprarPuerta.SetActive(false);
    }
}
