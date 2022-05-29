using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DeclararSpawns : MonoBehaviour
{
    
    public static DeclararSpawns Instance;
    private PhotonView view;
    private AudioSource sonido_comprar;
    
    
    [SerializeField] private GameObject spawn1;
    [SerializeField] private GameObject spawn2;
    [SerializeField] private GameObject spawn3;
    [SerializeField] private GameObject spawn4;
    [SerializeField] private GameObject spawn5;
    
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        view = GetComponent<PhotonView>();
        spawn2.SetActive(false);
        spawn3.SetActive(false);
        spawn4.SetActive(false);
        spawn5.SetActive(false);
        sonido_comprar = GetComponent<AudioSource>();
    }

    [PunRPC]
    public void PrimeraPuertaAbierta()
    {
        sonido_comprar.Play();
        spawn1.SetActive(false);
        spawn2.SetActive(true);
    }
    [PunRPC]
    public void SegundaPuertaAbierta()
    {
        sonido_comprar.Play();
        spawn2.SetActive(false);
        spawn3.SetActive(true);
    }
    [PunRPC]
    public void TerceraPuertaAbierta()
    {
        sonido_comprar.Play();
        spawn3.SetActive(false);
        spawn4.SetActive(true);
    }
    [PunRPC]
    public void CuartaPuertaAbierta()
    {
        sonido_comprar.Play();
        spawn4.SetActive(false);
    }
    
}
