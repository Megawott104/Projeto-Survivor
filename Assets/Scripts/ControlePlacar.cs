using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe acompanha o número de zumbis ue o jogador matou.
///</summary>

public class ControlePlacar : MonoBehaviour
{
    private Text placarUI;
    public static int zumbisMortos = -1;
    // Start is called before the first frame update
    void Start()
    {
        placarUI = GetComponent<Text>();
        zumbisMortos = 0;
    }

    // Update is called once per frame
    void Update()
    {//Exibe o número de zumbis mortos na tela
        string mensagemPlacar = "Zumbis mortos: " + zumbisMortos;
        placarUI.text = mensagemPlacar;   
    }
}
