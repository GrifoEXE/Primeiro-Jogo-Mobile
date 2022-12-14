using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;

    private string caminhoParaArquivo;

    private void Awake()
    {
        this.caminhoParaArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        var textoJson =  File.ReadAllText(this.caminhoParaArquivo);
        JsonUtility.FromJsonOverwrite(textoJson, this);
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
        File.WriteAllText(caminhoParaArquivo, textoJson);
    }

    public int QuantidadePontosLista()
    {
        return this.pontos.Count;
    }

    public IReadOnlyCollection<int> GetPontos()
    {
        return this.pontos.AsReadOnly();
    }
}
