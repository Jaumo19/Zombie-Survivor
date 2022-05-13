using System.Collections;
using System.Collections.Generic;
using Footsteps;
using UnityEngine;
using Photon.Pun;

public class Camara : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    [Range(1, 10)] public float smoothFactor;
    PhotonView view;

    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    private void Update()
    {
        if (view.IsMine)
        {

                Follow();
        }

    }

    void Follow()
    {
        Vector3 targetPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = targetPosition;
    }
}
