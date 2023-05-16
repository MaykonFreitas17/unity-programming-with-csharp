using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Sintaxes de uma variavel em C#
    // visibilidade nomeDaVariavel = valorDaVariavel;

    // Atributos/Variaveis Públicas
    public int intergeValue = 1; // valor inteiro (int)
    public float floatValue = 1.5f; // valor com ponto flutante (float)

    /* OBS: Por padrão, se a visibilidade do atributo/várivel não for declarada, ela será tratada como private */

    // Atributos/Variaveis Privatos
    private int intergePrivate = 2;
    private float floatPrivate = 2.5f;

    /* Tipos Primitivos de Atributos/Variaveis */
    // String - Texto
    public string word = "Hello World";

    // Booleano - True/False
    public bool isAlive = true;

    /* Alguns Atributos/Variaveis da propria Unity */

    public GameObject gameObject;
    public Transform transform;
    public Rigidbody2D rigidbody2D;
    public Collider2D collider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
