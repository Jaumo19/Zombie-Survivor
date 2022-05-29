using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FaseFinal : MonoBehaviour
{
    [SerializeField] private GameObject spawns_fase_final;
    [SerializeField] private GameObject mensaje;
    [SerializeField] private GameObject puertaNivel5;
    



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            spawns_fase_final.SetActive(true);
            puertaNivel5.SetActive(true);
            mensaje.SetActive(true);
        }
    }


}
