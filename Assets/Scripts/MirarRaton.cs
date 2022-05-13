using System.Collections;
using UnityEngine;


/* Danndx 2017 (youtube.com/danndx)
From video: youtu.be/_XdqA3xbP2A
thanks - delete me! :) */


public class MirarRaton : MonoBehaviour
{
    void Update()
    {
        faceMouse();
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