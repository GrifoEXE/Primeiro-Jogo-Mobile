using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pontuacao : MonoBehaviour
{
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
