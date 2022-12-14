using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPause : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0,1)]
    private float escalaTempoPause;

    private bool jogoEstaParado;

    // Update is called once per frame
    void Update()
    {
        if (this.TocandoTela())
        {
            if(this.jogoEstaParado)
            this.ContinuarJogo();
        }
        else{
            if (!this.jogoEstaParado)
            {
                PausarJogo();
            }
        }
    }

    private void PausarJogo()
    {
        this.painelPause.SetActive(true);
        mudarEscalaTempo(escalaTempoPause);
        this.jogoEstaParado = true;
    }

    private void ContinuarJogo()
    {
        StartCoroutine(this.EsperarEContinuarJogo());
    }

    private IEnumerator EsperarEContinuarJogo()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        mudarEscalaTempo(1);
        this.painelPause.SetActive(false);
        this.jogoEstaParado = false;
        
    }

    private bool TocandoTela()
    {
        return Input.touchCount > 0;
    }

    private void mudarEscalaTempo(float escala)
    {
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
