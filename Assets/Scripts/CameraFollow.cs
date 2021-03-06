using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;

    // Use this for initialization
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        tPlayer = GameObject.FindWithTag("Player");
        if (tPlayer != null)
        {
            tFollowTarget = tPlayer.transform;
            vcam.LookAt = tFollowTarget;
            vcam.Follow = tFollowTarget;
        }
    }
}