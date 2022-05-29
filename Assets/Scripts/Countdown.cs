using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    private float tiempo;
    private bool HaAcabado;

    private void Start()
    {
        HaAcabado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (HaAcabado != true)
        {
            if (tiempo < 30)
            {
                tiempo += Time.deltaTime;
                Debug.Log(tiempo);
            }
            else
            {
                Debug.Log("Ha acabado");
                HaAcabado = true;
                DuracionJuego.Instance.HaGanado();
            }
        }
       
        
    }
}
