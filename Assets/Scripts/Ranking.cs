using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;

    private void Awake()
    {
        this.pontos = new List<int>();
    }

    public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        this.SalvarRanking();
    }

    private void SalvarRanking()
    {
        //como salvar ranking
        var textoJson = JsonUtility.ToJson(this);
        var caminhoParaArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        File.WriteAllText(caminhoParaArquivo, textoJson);
        Debug.Log(Application.persistentDataPath);
    }
}