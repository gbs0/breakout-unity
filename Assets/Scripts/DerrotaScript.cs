using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             
	
	public Transform playerPaddle;
	
	public GameObject ballPrefab;
	
	public int lifes;
	GameObject player;
	GameObject ball;
	GameObject gameOver;
	UIScript component;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>(); 
		
		player = GameObject.Find("Jogador");
		
		ball = GameObject.Find("Bola");
		ball.GetComponent<SpriteRenderer>().enabled = true;
		ball.GetComponent<Rigidbody2D>(); 
		ball.GetComponent<Transform>();

		gameOver = GameObject.Find("GameOver");
		gameOver.SetActive(false);
		
		component = Object.FindObjectOfType<UIScript>();
		component.ChangeLife(lifes);
	}

	void Update()
	{
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
		
		Vector3 resetPosition = player.transform.position;
		resetPosition.x = 0;
		player.transform.position = resetPosition;
		ball.transform.position = playerPaddle.position;

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


