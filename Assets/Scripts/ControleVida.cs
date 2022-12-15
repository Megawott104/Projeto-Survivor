using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe faz o cálculo de dano na vida do jogador, e exibe a quantidade de vida restante na tela.
///</summary>

public class ControleVida : MonoBehaviour
{
    private Text vidaUI;
    public static int vidaPlayer = 999;
    // Start is called before the first frame update
    void Start()
    {
        vidaUI = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string mensagemVida = "Vida: " + vidaPlayer;
        vidaUI.text = mensagemVida;   
    }

    public static void DanoPlayer(int dano)
    {
        vidaPlayer -= dano;
    }
}
