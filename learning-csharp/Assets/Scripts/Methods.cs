using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public int Life;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Life); // Antes de Aumentar
        AddLife(10);
        Debug.Log(Life); // Depois de Aumentar
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Metodos/Fun��es */
    // sintaxes: void NomeMetodo (Parametros) { c�digo }
    void AddLife (int Life)
    {
        this.Life += Life;
    }
}
