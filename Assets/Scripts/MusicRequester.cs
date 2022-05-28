using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MusicRequester : MonoBehaviour
{
    [SerializeField] private AudioSource areaMusic = default;


    void Start()
    {
        areaMusic.volume = 0.05f;
        areaMusic.Play();
    }
    

}