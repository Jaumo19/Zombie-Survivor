using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public PhotonView view;
    public float tiempo;
    public float probabilidad;
    private void Start()
    {
        probabilidad = 0.25f;
        view = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (view.IsMine)
        {
            DecideSiEnemigo();
        }
    }

    [PunRPC]
    private void DecideSiEnemigo()
    {
        float random = Random.Range(0.0f, 100.0f);
        if (random < probabilidad)
        {
            GameObject.Instantiate(enemyPrefab, transform.position, transform.rotation);
        }

        tiempo += Time.deltaTime;
        if (tiempo >= 60)
        {
            
            tiempo = 0;
            probabilidad = probabilidad + 0.10f;
            Debug.Log("Nueva probabilidad: " + probabilidad);

        }
    }
}
