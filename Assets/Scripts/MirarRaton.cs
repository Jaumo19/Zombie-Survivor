using System.Collections;
using UnityEngine;
using Photon.Pun;


/* Danndx 2017 (youtube.com/danndx)
From video: youtu.be/_XdqA3xbP2A
thanks - delete me! :) */


public class MirarRaton : MonoBehaviour
{
    
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (view.IsMine)
        {
            faceMouse();
        }
    }

    void faceMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;
    }
}