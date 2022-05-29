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
    [SerializeField] private GameObject puertaNivel5;
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            titulo.text = "Edad Contemporánea";
            mensaje.text = "Un helicoptero llegará a rescararte en 30 segundos, sobrevive.";
            spawns_fase_final.SetActive(true);
            puertaNivel5.SetActive(true);
        }
    }


}
