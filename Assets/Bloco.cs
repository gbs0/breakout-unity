﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    static int counter;

    // Start is called before the first frame update
    void Start()
    {
    	counter++;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onDestroy() 
    {
    	counter--;
    }
}
