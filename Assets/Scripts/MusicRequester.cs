using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
 
public class MusicRequester : MonoBehaviour
{
    [SerializeField] private AudioSource areaMusic = default;
    private PhotonView view;
    


    void Start()
    {
        view = GetComponent<PhotonView>();
        if (view.IsMine)
        {
            areaMusic.volume = 0.05f;
            areaMusic.Play();
        }
    }
    

}