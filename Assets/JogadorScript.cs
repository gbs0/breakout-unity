﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t;                                        // Add data type for t variable
        t = new.Transform();
        t = GetComponent<Transform>();                      // Get Transform component
        // transform.position = new Vector3();              // Get a new Instance of position using Vector3
        if (Input.getKey(KeyCode.RightArrow)); {
            t.Translate(0.1f, 0, 0);                        // Add new translates for x axis
        }

        if  (Input.getKey(KeyCode.LeftArrow)); {
            t.Translate(-0.1f, 0, 0);
        }
    }
}