﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BolaScript : MonoBehaviour
{
    Rigidbody2D rb;             // Set the variable type
    public Text score;          // Set the score reference on UI;    
    public int playerScore;   // Hold player score
    public bool doublePoints;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();             // Pick RigidBody from game object
        //rb = new.RigidBody2D();                     // Init a new RigidBody on game object 
        Vector2 force = new Vector2(0, -200);         // Add x and y paramaters to Vector2 Variable
        rb.AddForce(force);                           // Call the method for addForce on RigidBody
        doublePoints = false;
    }

    // Update is called once per frame
    void Update()
    {
        //RigidBody2D colisorDebug;
        //colisorDebug = new.RigidBody2D();
        //colisorDebug = GetComponent<>();
    }

    // Methods for collision
    void OnCollisionEnter2D(Collision2D colisao)
    {
        print(colisao.gameObject.tag);
        if (colisao.gameObject.tag == "Bloco") {
            Destroy(colisao.gameObject);
            playerScore++; 
            score.text = "Score: " + playerScore.ToString() + "0";
        }

        if (colisao.gameObject.tag == "Crate001") {
            Destroy(colisao.gameObject);
                
        }
    }

    void OnCollisionStay2D(Collision2D colisao)
    {
        print("Stay");   
    }

    void OnCollisionExit2D(Collision2D colisao)
    {
        
        // ADD BALL TRANSFORM
        // print(colisao.transform.position.x);
        Vector2 forceLeft = new Vector2(-100f, 0);
        Vector2 forceRight = new Vector2(100f, 0);        
        //print(colisao.gameObject.transform.position);   // Pick value from player axis
        //float diferenca = transform.position.x - colisao.transform.x 
        if (colisao.gameObject.tag == "Player") {
            if (transform.position.x < colisao.transform.position.x)
                print("quina esquerda");
                rb.AddForce(forceLeft);
            } else {
                print("quina direita");
                rb.AddForce(forceRight);
            }    
        }
        
    }
