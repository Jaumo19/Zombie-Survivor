using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DetectarDaño : MonoBehaviour
{
    private PhotonView view;
    private float velocidadAtaque = 1f;
    private float puedeAtacar = 1f;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            if (view.IsMine)
            {
                if (velocidadAtaque <= puedeAtacar)
                {
                    VidaBase.Instance.recibirDaño(20);
                    puedeAtacar = 0f;
                }
                else
                {
                    puedeAtacar += Time.deltaTime;
                }
                
            }
        }
    }
}