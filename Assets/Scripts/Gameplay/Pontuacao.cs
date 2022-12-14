using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
    //acessor
    public int Pontos
    {
        get
        {
            return this.pontos;
        }
    }

    [SerializeField]
    private MeuEventoPersonalizadoInt aoPontuar;

    private int pontos;

    public void Pontuar()
    {
        pontos += 1;
        this.aoPontuar.Invoke(pontos);
    }
}


[Serializable]
public class MeuEventoPersonalizadoInt : UnityEvent<int>
{

}
