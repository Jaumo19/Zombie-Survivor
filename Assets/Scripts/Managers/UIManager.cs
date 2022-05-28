using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("Config")]
    [SerializeField] private Canvas mensaje_muerto;
    [SerializeField] private Button boton_muerto;
    [SerializeField] private Image vidaPlayer;
    [SerializeField] private TextMeshProUGUI vidaTMP;
    [SerializeField] private TextMeshProUGUI puntos;
    [SerializeField] private TextMeshProUGUI nombre;
    [SerializeField] private TextMeshProUGUI mensajeComprarPuerta;
    public  PhotonView view;

    private float vidaActual;
    private float vidaMax;
    private int puntuacion = 0;
    public GameObject puerta;
    public GameObject spawnsNivel1;
    private bool puerta1 = false;
    private int puntosInt;

    private void Awake()
    {
        Instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        mensajeComprarPuerta.enabled = false;
        mensaje_muerto.enabled = false;
        puntos.text = puntuacion.ToString();

        Button btn = boton_muerto.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        view = GetComponent<PhotonView>();
        nombre.text = PhotonNetwork.NickName;
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarUIPersonaje();
    }

    private void ActualizarUIPersonaje()
    {
        vidaPlayer.fillAmount = Mathf.Lerp(vidaPlayer.fillAmount, vidaActual / vidaMax, 10f * Time.deltaTime);

        vidaTMP.text = $"{vidaActual}/{vidaMax}";
    }

    public void ActualizarVidaPersonaje(float pVidaActual, float pVidaMax)
    {
        vidaActual = pVidaActual;
        vidaMax = pVidaMax;
    }

    public void AñadirPuntos()
    {
        puntuacion += 100;
        puntos.text = puntuacion.ToString();
        
    }
    public void GameOver()
    {
        mensaje_muerto.enabled = true;
    }
    void TaskOnClick()
    {
        PhotonNetwork.Disconnect();
        PhotonNetwork.LoadLevel("Cargando");
    }

    public void RestarDinero(int cantidad)
    {
        puntuacion -= cantidad;
        puntos.text = puntuacion.ToString();
    }
}
