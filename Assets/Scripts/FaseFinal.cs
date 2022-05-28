using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FaseFinal : MonoBehaviour
{
    [SerializeField] private GameObject spawns_fase_final;
    [SerializeField] private TextMeshProUGUI titulo;
    [SerializeField] private TextMeshProUGUI mensaje;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("Has acabado");
            titulo.text = "Edad Contemporánea";
            titulo.text = "Un helicoptero llegará a rescararte en 30 segundos, sobrevive.";
            spawns_fase_final.SetActive(true);
        }
        
        
    }
}
