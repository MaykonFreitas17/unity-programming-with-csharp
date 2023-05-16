using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileAndDoWhile : MonoBehaviour
{
    public int ItensInScene = 5;
    public int CoinInScene = 10;

    // Start is called before the first frame update
    void Start()
    {
        while (ItensInScene > 0)
        {
            Debug.Log("Get Item!");
            ItensInScene -= 1;
        }

        do
        {
            Debug.Log("+ 10 Coin");
            CoinInScene += 10;
        } while (CoinInScene <= 999);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
