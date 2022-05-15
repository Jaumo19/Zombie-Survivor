using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.CompareTag("Enemigo"))
      {
         Destroy(collision.gameObject);
         UIManager.Instance.AñadirPuntos();

      }
      Destroy(gameObject);
   }
}
