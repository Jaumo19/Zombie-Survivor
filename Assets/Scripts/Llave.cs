using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave : MonoBehaviour
{
    public GameObject puertaNivel1;
    public GameObject spawnsNivel1;
    private int nivel;


    void Start()
    {
        nivel = 1;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("A");
            gameObject.SetActive(false);
            Destroy(spawnsNivel1);
            puertaNivel1.SetActive(false);
            nivel++;
        }
    }
}