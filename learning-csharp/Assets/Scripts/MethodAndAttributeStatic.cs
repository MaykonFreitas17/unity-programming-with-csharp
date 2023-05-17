using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodAndAttributeStatic : MonoBehaviour
{
    /* Classe, Métodos e Atributos Estaticos (Static) */
    // Sintaxe: public static NomeClasse NomeDaClasse;
    public static MethodAndAttributeStatic MAStatic;

    // Start is called before the first frame update
    void Start()
    {
        // Definindo o valor da Variavel Estatica
        MAStatic = this; // Passando a propria classe para a variavel;
    }

    // Para acessar os atributos e methos de Classes Estatica:
    // Sintaxe (Atributos): NomeClasseEstatica.VariavelEstatica.Atributo;
    // Sintaxe (Metodo): NomeClasseEstatica.VariavelEstatica.Metodo();

}
