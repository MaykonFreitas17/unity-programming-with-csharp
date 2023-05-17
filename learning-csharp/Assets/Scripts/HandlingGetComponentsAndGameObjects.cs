using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlingGetComponentsAndGameObjects : MonoBehaviour
{
    /* Manipulando GetComponent e GameObjects */
    public GameObject Object;

    // Start is called before the first frame update
    void Start()
    {
        // Desativando o Objeto
        Object.SetActive(false); // Para Ativar, passe true

        // Desativando o Component do Objeto
        Object.GetComponent<BoxCollider2D>().enabled = false;

        // Verificando se o Objeto está ativo na Cena
        if (Object.activeSelf)
        {
            Debug.Log("O objeto " + Object.name + " está ativo");
        } else
        {
            Debug.Log("O objeto " + Object.name + " não está ativo");
        }
    }
}
