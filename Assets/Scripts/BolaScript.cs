using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaScript : MonoBehaviour
{
    Rigidbody2D rb;             
    public Text score;       
    public int playerScore;   	
    public bool doublePoints;
    public bool inPlay;

    public Transform playerPaddle;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();             // Pick RigidBody from game object
        //rb = new.RigidBody2D();                     // Init a new RigidBody on game object 
        // Vector2 force = new Vector2(0, -200);         // Add x and y paramaters to Vector2 Variable
        // rb.AddForce(force);                           // Call the method for addForce on RigidBody
    }

    void Update()
    {
        //RigidBody2D colisorDebug;
        //colisorDebug = new.RigidBody2D();
        //colisorDebug = GetComponent<>();

        if (!inPlay) {
            transform.position = playerPaddle.position;
        } 

        if  (Input.GetKeyDown(KeyCode.Space) && !inPlay) {
            inPlay = true;
            rb.AddForce(Vector2.up * 400);
        }

    }

    
    void OnCollisionEnter2D(Collision2D colisao)
    {
        // print(colisao.gameObject.tag);

        if (colisao.gameObject.tag == "Bloco") {
            Destroy(colisao.gameObject);
            doublePoints = false;
            playerScore++; 
            score.text = "Score: " + playerScore.ToString() + "0";
        }

        // if (colisao.gameObject.tag == "") {
        //     Destroy(colisao.gameObject);
        //     doublePoints = true;
        //     playerScore += 2;
        //     score.text = "Score: " + playerScore.ToString() + "0";
        // }

        // if (colisao.gameObject.tag == "Crate001" && doublePoints) {}
        // if (colisao.gameObject.tag == "Crate001" && !doublePoints) {}
    }

    void OnCollisionStay2D(Collision2D colisao)
    {
        // print("Stay");   
    }

    void OnCollisionExit2D(Collision2D colisao)
    {

        Vector2 forceLeft = new Vector2(-100f, 0);
        Vector2 forceRight = new Vector2(100f, 0);

        if (colisao.gameObject.tag == "Player") {
            if (transform.position.x < colisao.transform.position.x) {
                // print("quina esquerda");
                rb.AddForce(forceLeft);
            } else {
                // print("quina direita");
                rb.AddForce(forceRight);
            }    
        }    
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Bottom")) {
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }


}