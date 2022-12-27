using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PainelRanking : MonoBehaviour
{
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocado;
    private void Start()
    {
        var listaColocados = this.ranking.GetPontos();
        for(var i = 0; i<listaColocados.Count; i++)
        {
            if(i >= 5)
            {
                break;
            }
            var colocado = GameObject.Instantiate(this.prefabColocado, this.transform);
            colocado.GetComponent<ItemRanking>().Configurar(i, listaColocados[i].nome, listaColocados[i].pontos);
            
        }
    }
}
