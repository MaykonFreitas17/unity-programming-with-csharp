using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsIfElse : MonoBehaviour
{
    public int age;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        if (age > 18) {
            Debug.Log("Sou Maior de Idade!");
        } else if (age == 18) {
            Debug.Log("Eu tenho 18 anos");
        } else {
            Debug.Log("Não Sou Maior de Idade!");
        }

        if (isAlive) {
            Debug.Log("Estou Vivo!");
        } else {
            Debug.Log("Estou Morto!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
