using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;
    
    private Animator animator;
    private AudioSource sonido_disparo;
    
    PhotonView view;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float fireRate = 0.5F;
    private float _nextFire = 0.0F;


    // Update is called once per frame

    void Start()
    {
        sonido_disparo = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (view.IsMine)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            var velocidad = movement * moveSpeed * Time.deltaTime;
            if (Input.GetButton("Fire1") && Time.time > _nextFire)
            {
                _nextFire = Time.time + fireRate;
                Shooting();
            }
        }

    }
    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        /*Vector2 lookDir = mousePos - rb.position;
        float angle = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.rotation = angle;*/


        /*gob.transform.position = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(gob.transform, Vector3.forward);*/
    }

    void Shooting()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        sonido_disparo.Play();
    }
}
