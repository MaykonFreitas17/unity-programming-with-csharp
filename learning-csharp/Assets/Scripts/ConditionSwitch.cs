using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionSwitch : MonoBehaviour
{
    public int weekday;
    // Start is called before the first frame update
    void Start()
    {
        // Switch
        switch(weekday)
        {
            case 1:
                Debug.Log("Domingo");
                break;
            case 2:
                Debug.Log("Segunda");
                break;
            default:
                Debug.Log("Erro!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
