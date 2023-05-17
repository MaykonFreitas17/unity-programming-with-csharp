using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonAndOnMouseDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* Classe Input */

        // sintaxe: Input.GetKey, .GetKeyDown, GetKeyUp
        // Para informar a tecla use: KeyCode.TECLA

        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("Andando Para Cima");
        }

        if (Input.GetKey(KeyCode.S)) {
            Debug.Log("Andando Para Baixo");
        }

        if (Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Andando Para Esquerda");
        }

        if (Input.GetKeyUp(KeyCode.D)) {
            Debug.Log("Andando Para Direita");
        }
    }

    // Trabalhando com o Click do Mouse

    // Quando o Mouse é precionado em cima do Objeto
    private void OnMouseDown()
    {
        Debug.Log("Cliquei");
    }
}
