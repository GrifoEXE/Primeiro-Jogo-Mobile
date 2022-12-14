using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPause : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;
    [SerializeField, Range(0,1)]
    private float escalaTempoPause;

    // Update is called once per frame
    void Update()
    {
        if (this.TocandoTela())
        {
            this.ContinuarJogo();
        }
        else{
            PausarJogo();
        }
    }

    private void PausarJogo()
    {
        this.painelPause.SetActive(true);
        mudarEscalaTempo(escalaTempoPause);
    }

    private void ContinuarJogo()
    {
        this.painelPause.SetActive(false);
        mudarEscalaTempo(1);
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
