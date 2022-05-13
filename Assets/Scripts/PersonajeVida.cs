using System;
using UnityEngine;
using Photon.Pun;
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

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.T)){
            recibirDaño(10);
        }

        if (Input.GetKeyDown(KeyCode.R)){
            restaurarSalud(10);
        }
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
        PhotonNetwork.Destroy(jugador);
     
        
    }
    protected override void ActualizarBarraVida(float vidaActual, float vidaMax)
    {
        UIManager.Instance.ActualizarVidaPersonaje(vidaActual, vidaMax);
    }
}
