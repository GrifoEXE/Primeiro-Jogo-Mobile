using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMouse : MonoBehaviour
{
    private void Update()
    {
        var posicao = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = posicao;
    }
}
