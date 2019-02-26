using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RigidBody2D rb;                         // Set the variable type
        //rb = new.RigidBody2D();                 // Init a new RigidBody on game object
        rb = GetComponent<RigidBody2D>();       // Pick RigidBody from game object 
        Vector2 force = new Vector2(0, -200);   // Add x and y paramaters to Vector2 Variable
        rb.AddForce(force);                     // Call the method for addForce on RigidBody
    }

    // Update is called once per frame
    void Update()
    {
        //RigidBody2D colisorDebug;
        //colisorDebug = new.RigidBody2D();
        //colisorDebug = GetComponent<>();
    }
}
