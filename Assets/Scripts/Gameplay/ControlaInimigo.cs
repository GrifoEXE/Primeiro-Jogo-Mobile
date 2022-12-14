using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private float forca;

    private Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        var deslocamento = alvo.position - this.transform.position;
        deslocamento = deslocamento.normalized;
        deslocamento *= this.forca;
        this.transform.position += deslocamento * Time.deltaTime;
        this.fisica.AddForce(deslocamento, ForceMode2D.Force);
    }
    public void SetAlvo(Transform novoAlvo)
    {
        this.alvo = novoAlvo;
    }
}
