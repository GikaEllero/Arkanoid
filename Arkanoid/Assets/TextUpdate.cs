using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUpdate : MonoBehaviour
{
    public TextMesh textoScore;
    public TextMesh textoVida;

    // Update is called once per frame
    void Update()
    {
        textoScore.text = "Score: " + GameManager.PlayerScore;
        textoVida.text = "Vida: " + GameManager.Vidas;
    }
}
