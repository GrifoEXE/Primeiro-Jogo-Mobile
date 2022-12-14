using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    [SerializeField]
    private TextoDinamico textoPontuacao;
    private Pontuacao pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindObjectOfType<Pontuacao>();
        var totalDePontos = -1;
        if(this.pontuacao != null)
        {
            totalDePontos = this.pontuacao.Pontos;
        }

        this.textoPontuacao.AtualizarTexto(totalDePontos);
    }

}
