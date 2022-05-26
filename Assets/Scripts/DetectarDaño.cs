using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DetectarDaño : MonoBehaviour
{
    private PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            if (view.IsMine)
            {
                VidaBase.Instance.recibirDaño(20);
            }
        }
    }
}