using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    public static int counter { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
    	counter++;    
    }

    // Update is called once per frame
    void Update()
    {
    	
    }

    void OnDestroy() 
    {
    	counter--;
    }
}
