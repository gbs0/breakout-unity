using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             
	
	// Pick Ball Position Child Transform
	GameObject playerPaddle;
	
	// public GameObject ballPrefab;
	public GameObject ballPrefab;
	
	int textScore = 0;
	public int lifes;
	GameObject player;
	GameObject ball;
	GameObject gameOver;
	UIScript component;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>(); 
		
		player = GameObject.Find("Jogador");
		
		// And this will not be found
		
		ball = GameObject.Find("Bola");		
		

		ball.GetComponent<SpriteRenderer>().enabled = true;
		ball.GetComponent<Rigidbody2D>(); 
		ball.GetComponent<Transform>();

		gameOver = GameObject.Find("GameOver");
		gameOver.SetActive(false);

		playerPaddle = GameObject.Find("/Jogador/Ball Position");

		component = Object.FindObjectOfType<UIScript>();
		component.ChangeLife(lifes);
	}

	void Update()
	{
		// print(ball);
		// this should be an bool condition
		// if (hit_times >= 3) {
		// 	Debug.Log("Defeat!");
		// 	if(Time.timeScale == 1)
		// 			Time.timeScale == 0;
		// 	}
	}

	void Respawn()
	{
		
		Instantiate(ballPrefab);
		ball = GameObject.Find("Bola(Clone)");
		Vector3 resetPosition = player.transform.position;
		resetPosition.x = 0;
		player.transform.position = resetPosition;
		// When call Respawn(), ball is destroyed
		ball.transform.position = playerPaddle.transform.position;

	}

	void Restart() 
	{
		SceneManager.LoadScene("Menu");
	}

	void OnTriggerEnter2D(Collider2D colisor)
	{
		// print(colisor.gameObject.tag);

	}	

	void OnTriggerStay2D(Collider2D colisor)
	{

	}

	void OnTriggerExit2D(Collider2D colisor)
	{
		if(colisor.tag == "Bola")
		{
			Destroy(colisor.gameObject);
			if (lifes > 0) {
				Invoke("Respawn", 2);
				Debug.Log("Hit Barrier");
				lifes--;
				component.ChangeLife(lifes);
			} else {
				player.GetComponent<JogadorScript>().enabled = false; // Get script component from player
				ball.GetComponent<SpriteRenderer>().enabled = false;	// Get SpriteRenderer component
				gameOver.SetActive(true);
				Invoke("Restart", 3);
			}
		}
	}
}


