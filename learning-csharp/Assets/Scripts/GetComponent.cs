using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    /* Trabalhando com GetComponent - Para Acessar Componentes do Objeto */
    private Rigidbody2D rig2D;
    private BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        // Acessando o componente Rigidbody2D do Objeto
        rig2D = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
