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

    
    AudioSource audioSource;

    PhotonView view;

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float fireRate = 0.5F;
    private float _nextFire = 0.0F;


    // Update is called once per frame

    void Start() {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource> ();
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
            animator.SetFloat("Velocidad", velocidad.magnitude);
            if (movement.x != 0 || movement.y != 0)
            {
                if (!audioSource.isPlaying)
                {

                    audioSource.Play();
                    audioSource.pitch = Random.Range(0.4f, 0.4f);
                }

            }
            else
            {

                audioSource.Stop();
                animator.GetComponent<Animator>().enabled = false;
            }
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
    }
}
