using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    /* Sintaxes dos arrays */
    // visibilidade TipoVariavel[] NomeVariavel;
    // visibilidade TipoVariavel[] NomeVariavel = new TipoVariavel[TamanhoDoArray];
    private GameObject[] Players;

    // Start is called before the first frame update
    void Start()
    {
        // Alimentando o Array Player
        Players = GameObject.FindGameObjectsWithTag("Player");
        
        // Pecorrendo o Array de Players
        foreach (GameObject player in Players)
        {
            Debug.Log(player.name);
        }
    }

    // Update is called once per frame
    void Upadate()
    {
        
    }
}
