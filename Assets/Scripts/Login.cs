using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class Login : MonoBehaviour
{

    public Text usuario;
    public Text password;
    public Text datosIncorrectos;

    WWWForm form;

    void Start()
    {
        datosIncorrectos.enabled = false;
    }
    public void comprobarLogin()
    {
        StartCoroutine(comprobacionBBDD());
    }
    IEnumerator comprobacionBBDD()
    {
        form = new WWWForm();
        form.AddField("usuario", usuario.text);
        form.AddField("password", password.text);

        WWW w = new WWW("https://zombiesurvivor.000webhostapp.com/tratarDatos.php", form);
        yield return w;
        Debug.Log(w.text);
        if (w.text == "0")
        {
            PhotonNetwork.NickName = usuario.text;
            SceneManager.LoadScene("Cargando");
        }
        else
        {
            datosIncorrectos.enabled = true;
        }
    }

    public void comprobarRegistro()
    {
        Application.OpenURL("https://zombiesurvivor.000webhostapp.com/registrarse.html");
    }
}
