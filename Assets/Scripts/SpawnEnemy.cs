using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PhotonView view;
    float tiempo_contado;
    float tiempo_contar;

    void Start()
    {
        tiempo_contado = 2f;
        tiempo_contar = 2f;
    }

    void Update()
    {
        if (tiempo_contado >= tiempo_contar)
        {
            DecideSiEnemigo();
            tiempo_contado = 0f;
        }
        else
        {
            tiempo_contado += Time.deltaTime;
        }
         

    }

    private void DecideSiEnemigo()
    {
        GameObject.Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
