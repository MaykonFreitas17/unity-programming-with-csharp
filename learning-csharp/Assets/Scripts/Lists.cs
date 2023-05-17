using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    /* Listas */

    // Sintaxe: List<TipoLista> NomeLista = new List<TipoLista>();
    public List<int> Values = new List<int>(); // Declarando uma lista de Inteiros
    
    // Criando a Classe Enemy
    [System.Serializable]
    public class Enemy
    {
        public string Name;
        public int Speed;
        public int Damage;
    }

    // Criando uma Lista de Enemy (Inimigos)
    public List<Enemy> enemies = new List<Enemy>();

    private void Start()
    {
        // Adicionando Elementos a lista de Inimigos
        enemies.Add(new Enemy());
        enemies.Add(new Enemy());
        enemies.Add(new Enemy());
        enemies.Add(new Enemy());
    }
}
