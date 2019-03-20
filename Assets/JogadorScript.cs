using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorScript : MonoBehaviour
{   
    Transform t;                                      // Add data type for t variable
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();                      // Get Transform component        
    }

    // Update is called once per frame
    void Update()
    {

        // transform.position = new Vector3();              // Get a new Instance of position using Vector3
        if (Input.GetKey(KeyCode.RightArrow)) {
            t.Translate(0.1f, 0, 0);                        // Add new translates for x axis
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            t.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q)) {
            t.Rotate(0, 0, 6f);
        }

        if (Input.GetKey(KeyCode.E)) {
            t.Rotate(0, 0, -6f);
        }
        
        // Restrict Player Area
        Vector3 posicao = t.position;
        // if (posicao.x > 2.9f) posicao.x = 2.9f;
        // if (posicao.x < -2.9f) posicao.x = -2.9f;
        posicao.x = Mathf.Clamp(posicao.x, -2.9f, 2.9f);  //One line statement
        transform.position = posicao;
    }

}
