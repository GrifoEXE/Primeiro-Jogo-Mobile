using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleMouse : MonoBehaviour
{
    private void Update()
    {
        var posicao = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = posicao;
    }
}
