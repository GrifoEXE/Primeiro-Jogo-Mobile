using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemRanking : MonoBehaviour
{
    [SerializeField]
    private Text textoColocacao;
    [SerializeField]
    private Text textoNome;
    [SerializeField]
    private Text textoPontos;

    public void Configurar(int colocacao, string nome, int pontuacao)
    {
        this.textoColocacao.text = colocacao.ToString();
        this.textoNome.text = nome;
        this.textoPontos.text = pontuacao.ToString();
    }

}
