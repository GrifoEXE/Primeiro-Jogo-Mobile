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

        this.textoPontuacao.AtualizarTexto(this.pontuacao.Pontos);
    }

}
