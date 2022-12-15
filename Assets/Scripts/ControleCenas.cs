using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla a mudança de cena.
///Como o jogo começa já na fase, ao apertar a tecla C muda a cena para os créditos finais.
///</summary>

public class ControleCenas : MonoBehaviour
{
    public static int tempoInicial;
    int tempoEspera = 3;
    bool trocaCena = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ControleJogo.stageClear != 0)
        {
            if(Input.GetKey(KeyCode.C))
            {
                SceneManager.LoadScene("Créditos");
            }
        }
            
    }
}

