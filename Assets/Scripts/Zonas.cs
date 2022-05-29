using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Zonas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titulo;
    [SerializeField] private TextMeshProUGUI descripcion;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.name == "PrimeraZona")
            {
                titulo.text = "Prehistória";
                descripcion.text = "Después de Altamira todo parece decadente";
            }

            if (gameObject.name == "SegundaZona")
            {
                titulo.text = "Edad Antigua";
                descripcion.text = "La paciencia es amarga, pero su fruto es dulce";
            }
            if (gameObject.name == "TerceraZona")
            {
                titulo.text = "Edad Media";
                descripcion.text = "Estamos progresando. La religión es la base de todo hombre";
            }
            if (gameObject.name == "CuartaZona")
            {
                titulo.text = "Edad Moderna";
                descripcion.text = "La mayor sabiduría que existe es conocerse a uno mismo";
            }
            if (gameObject.name == "QuintaZona")
            {
                titulo.text = "Edad Contemporánea";
                descripcion.text = "Del pasado no tiene usted que recordar más que lo placentero";
            }
        }
        
    }
}
