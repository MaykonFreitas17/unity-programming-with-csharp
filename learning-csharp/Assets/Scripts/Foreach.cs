using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    public string[] Enemies = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        // Definindo o elementos do array Enemies
        Enemies[0] = "Goblin lvl 1";
        Enemies[1] = "Goblin lvl 2";
        Enemies[2] = "Goblin lvl 3";

        foreach(string enemy in Enemies)
        {
            Debug.Log(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
