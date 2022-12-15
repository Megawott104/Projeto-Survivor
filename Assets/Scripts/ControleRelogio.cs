using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla o relógio do jogo. Quando o jogo acaba, o rélogio congela.
///</summary>

public class ControleRelogio : MonoBehaviour
{
    private Text textoRelogio;
    private float contregreTempoDuracao;
    private float contregreTempoInicio;
    public static bool tempoEsgotado;
    public static int tempoRestante;
    int segundosRestantes;
    int minutosRestantes;
    // Start is called before the first frame update
    void Start()
    {
        textoRelogio = GetComponent<Text>();
        ContRegreTempoReset(60);
        tempoEsgotado = false;
    }

    // Update is called once per frame
    void Update()
    {
        string mensagemTempo = " ";
        if(ControlePlacar.zumbisMortos < 90 && !tempoEsgotado && ControleVida.vidaPlayer > 0)
        {
            //se deixar a atribuicao dentro desse if
            //a contagem para quando vencer o jogo
            tempoRestante = (int)ContRegreSegRestantes();
            minutosRestantes = tempoRestante/60;
            segundosRestantes = tempoRestante % 60;
            mensagemTempo = PreencheZeros(minutosRestantes) + ":" + PreencheZeros(segundosRestantes);

            //Se o tempo acabar, congela a contagem.
            if (tempoRestante <= 0)
            {
                tempoEsgotado = true;
            }
        }
        mensagemTempo = PreencheZeros(minutosRestantes) + ":" + PreencheZeros(segundosRestantes);
        textoRelogio.text = mensagemTempo;
    }

    private void ContRegreTempoReset(float tempoinicial)
    {
        //Define onde comeca a contagem regressiva
        contregreTempoDuracao = tempoinicial;
        contregreTempoInicio = Time.time;
    }

    private float ContRegreSegRestantes()
    {
        //Faz a contagem regressiva dos segundos
        //Conta quanto tempo passou desde o inicio da contagem
        float tempoDecorrido = Time.time - contregreTempoInicio;
        //e subtrai o resultado do tempo maximo da contagem
        float tempoRestante = contregreTempoDuracao - tempoDecorrido;
        return tempoRestante;
    }

    private string PreencheZeros(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
