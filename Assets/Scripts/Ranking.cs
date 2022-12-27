using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private static string NOME_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<Colocado> listaColocados;

    private string caminhoParaArquivo;

    private void Awake()
    {
        this.caminhoParaArquivo = Path.Combine(Application.persistentDataPath, NOME_ARQUIVO);
        var textoJson =  File.ReadAllText(this.caminhoParaArquivo);
        JsonUtility.FromJsonOverwrite(textoJson, this);
    }

    public void AdicionarPontuacao(int pontos, string nome)
    {
        var novoColocado = new Colocado(nome, pontos);
        this.listaColocados.Add(novoColocado);
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
        return this.listaColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetPontos()
    {
        return this.listaColocados.AsReadOnly();
    }
}


public class Colocado
{
    public string nome;
    public int pontos;

    public Colocado(string nome, int pontos)
    {
        this.nome = nome;
        this.pontos = pontos;
    }
}