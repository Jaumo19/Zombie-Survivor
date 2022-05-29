using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;

public class DuracionJuego : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI texto_tiempo;
    [SerializeField] private Canvas mensaje_ganado;
    [SerializeField] private GameObject spawns5;
    private float tiempo;
    private float minutos;
    private float segundos;
    public PhotonView view;

    public static DuracionJuego Instance;

    
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        mensaje_ganado.enabled = false;
        view = GetComponent<PhotonView>();
    }
    private void Update()
    {
        tiempo += Time.deltaTime;
    }

    public void HaGanado()
    {
        spawns5.SetActive(false);
        mensaje_ganado.enabled = true;
        minutos = Mathf.Floor(tiempo / 60);
        segundos = tiempo%60;
        texto_tiempo.text = "Tiempo: " + minutos + ":" + Mathf.RoundToInt(segundos);
        if (view.IsMine)
        {
            PhotonNetwork.Disconnect();
        }
        
        
    }
}
