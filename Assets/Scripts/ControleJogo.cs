using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla os estados do jogo.
///Quando o jogador atingir as condições de vitória (matar todos os zumbis, ou sobreviver até o tempo acabar)
///ou a de derrota (sua vida chegar a 0), toca a música de vitória ou de derrota e congela os movimentos do objetos.
///</summary>

public class ControleJogo : MonoBehaviour
{
    public static int stageClear;
    private bool criouTexto = false;
    public AudioSource audio;
    public AudioClip vitoria;
    public AudioClip derrota;
    // Start is called before the first frame update
    void Start()
    {
        stageClear = 0;
        //0 = jogo em progresso
        //1 = vitoria
        //2 = derrota
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ControleRelogio.tempoEsgotado && ControleVida.vidaPlayer > 0)
        {//Se o jogador sobreviveu
            stageClear = 1;
            if(!criouTexto)
            {
                criaTexto("Parabéns! Você sobreviveu ao ataque!\n\nPressione C para ir aos creditos");
                audio.PlayOneShot(vitoria, 0.5f);
                criouTexto = true;
            }
            ControleCenas.tempoInicial = (int)Time.time;
        }else if(ControleVida.vidaPlayer > 0 && ControlePlacar.zumbisMortos >= 90)
        {//Se o jogador matou todos os zumbis
            stageClear = 1;
            if(!criouTexto)
            {
                criaTexto("Parabéns! Você sobreviveu ao ataque!\n\nPressione C para ir aos creditos");
                audio.PlayOneShot(vitoria, 0.7f);
                criouTexto = true;
            }
        }
        else if(ControleVida.vidaPlayer <= 0 && ControlePlacar.zumbisMortos < 90 && ControleRelogio.tempoEsgotado == false)
        {//Se o jogador morreu antes do tempo acabar e antes de matar todos os zumbis
            stageClear = 2;
            if(!criouTexto)
            {
                criaTexto("Apesar dos esforços do nosso herói, a fortaleza caiu...\n\nPressione C para ir aos creditos");
                audio.PlayOneShot(derrota, 0.7f);
                criouTexto = true;
            }
        }

        //Se o jogo acabar, congela os inimigos e o player
        if(stageClear != 0)
        {
            MoveFPS.velocidade = 0f;
            Zumbi.velocidade = 0f;
        }
    }

    public static void criaTexto(string mensagem){
        //declaracao do canvas
        GameObject newCanvas = GameObject.Find("Canvas");
        Font arial = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        //Texto
        GameObject newTexto = new GameObject("textoResultado");
        newTexto.transform.parent = newCanvas.transform;

        Text texto = newTexto.AddComponent<Text>();
        texto.font = arial;
        texto.fontSize = 21;
        texto.text = mensagem;
        texto.color = Color.black;

        //Posicao do texto
        RectTransform rectTransform = texto.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 50, -31);
        rectTransform.sizeDelta = new Vector2(400,120);
    }
}
