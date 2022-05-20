using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private void Start()
    {
       
    }

    void Update()
    {
        DecideSiEnemigo();
    }

    private void DecideSiEnemigo()
    {
        float random = Random.Range(0.0f, 100.0f);
        if (random < 0.005f)
        {
            GameObject.Instantiate(enemyPrefab, transform.position, transform.rotation);
        }
    }
}
