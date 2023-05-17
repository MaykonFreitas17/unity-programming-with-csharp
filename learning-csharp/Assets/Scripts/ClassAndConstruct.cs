using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassAndConstruct : MonoBehaviour
{
    /* Classes */
    // Sintaxe: visibilidade class NomeDaClass { }

    // Mostrar no Editor da Unity
    [System.Serializable]
    public class Dog
    {
        // Atributos
        public string race;
        public int age;
        public int length;

        // Metodo Construtor
        public Dog(string Race, int Age, int Length)
        {
            this.race = Race;
            this.age = Age;
            this.length = Length;
        }
    }

    // Instanciando uma Classe
    public Dog dog = new Dog("Lhasa Apso", 1, 28);
}
