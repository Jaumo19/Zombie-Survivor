using System;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;

public class PersonajeVida : VidaBase
{
    public GameObject jugador;
    public static Action EventoPersonajeDerrotado;
    public bool puedeSerCurado => Salud < saludMax;

    protected override void Start()
    {
        base.Start();
        ActualizarBarraVida(Salud, saludMax);
    }

    public void restaurarSalud(float cantidad){
        if (puedeSerCurado){
            Salud += cantidad;
            if (Salud > saludMax){
                Salud = saludMax;
            }
            ActualizarBarraVida(Salud, saludMax);
        }
    }

    protected override void PersonajeDerrotado()
    {
        if (view.IsMine)
            Debug.Log(PhotonNetwork.NickName);
            Debug.Log("Ha muerto");
        {
            if (jugador != null)
                Debug.Log("Ha muerto");
            {
                PhotonNetwork.Disconnect();
            }
            //UIManager.Instance.GameOver();
            UIManager.Instance.GameOver();
        }


        }
    protected override void ActualizarBarraVida(float vidaActual, float vidaMax)
    {
        UIManager.Instance.ActualizarVidaPersonaje(vidaActual, vidaMax);
    }
}
