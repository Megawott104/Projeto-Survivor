using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Thiago Vinicius Pereira Graciano de Souza
//RA: 11201722589

///<summary>
///Esta classe controla o movimento da câmera a partir do movimento do mouse.
///</summary>

public class AlvoFPS : MonoBehaviour
{
    float mouseX;
    float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Se o jogo acabar, congela a camera
        if(ControleJogo.stageClear == 0)
        {
            //Se for (mouseX, mouseY, 0f),
            //o movimento vertical vira horizontal dentro do jogo,
            //e o movimento horizontal vira vertical
            mouseX += Input.GetAxis("Mouse X");
            mouseY += Input.GetAxis("Mouse Y");
        }
        
        //Debug.Log(mouseX);
        //Debug.Log(mouseY);
        //Deixei -mouseY para o movimento vertical da mira nao ficar invertido
        transform.eulerAngles = new Vector3(-mouseY * 2,mouseX * 5,0f);
    }
}
