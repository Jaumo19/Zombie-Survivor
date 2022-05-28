using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclararSpawns : MonoBehaviour
{
    
    public static DeclararSpawns Instance;
    
    
    [SerializeField] private GameObject spawn1;
    [SerializeField] private GameObject spawn2;
    [SerializeField] private GameObject spawn3;
    /*[SerializeField] private GameObject spawn4;
    [SerializeField] private GameObject spawn5;*/
    
    private void Awake()
    {
        Instance = this;

    }
    void Start()
    {
        spawn2.SetActive(false);
        spawn3.SetActive(false);
        /*spawn4.SetActive(false);
        spawn5.SetActive(false);*/
    }

    public void PrimeraPuertaAbierta()
    {
        spawn1.SetActive(false);
        spawn2.SetActive(true);
    }
    public void SegundaPuertaAbierta()
    {
        spawn2.SetActive(false);
        spawn3.SetActive(true);
    }

    public void TerceraPuertaAbierta()
    {
        spawn3.SetActive(false);
    }
    
}
