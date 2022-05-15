using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaBase : MonoBehaviour
{
    
    
    public static VidaBase Instance;
    
    
    [SerializeField] protected float saludInicial;
    [SerializeField] protected float saludMax;
    

    
    private void Awake()
    {
        Instance = this;
    }
    public float Salud { get; protected set; }
    // Start is called before the first frame update
    protected virtual void  Start()
    {
        Salud = saludInicial;
    }
    public void recibirDaño(float cantidad){
        if (cantidad <= 0){
            return;
        }
        if (Salud > 0f){
            Salud -= cantidad;
            ActualizarBarraVida(Salud, saludMax);
            if (Salud <= 0f){
                ActualizarBarraVida(Salud, saludMax);
                PersonajeDerrotado();
            }
        }
    }

    protected virtual void ActualizarBarraVida(float vidaActual, float vidaMax){

    }

    protected virtual void PersonajeDerrotado(){

    }
}
