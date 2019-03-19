using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             // Set the variable type
	public GameObject prefab;
	public int hit_times;
	bool isGoingUp = true;
	GameObject player;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>(); 
		player = GameObject.Find("Jogador");
	}

	void Update()
	{
		// this should be an bool condition
		if (hit_times >= 3) {
			Debug.Log("Defeat!");
		// 	if(Time.timeScale == 1)
		// 			Time.timeScale == 0;
		// 	} else {
		// 		Time.timeScale == 1;
		}
	}

	void Respawn()
	{
		Instantiate(prefab);
	}

	void OnTriggerEnter2D(Collider2D colisor)
	{
		print(colisor.gameObject.tag);
		// if tag == bola 
		// hit_times++;
	}	

	void OnTriggerStay2D(Collider2D colisor)
	{

	}

	void OnTriggerExit2D(Collider2D colisor)
	{
		if(colisor.tag == "Bola")
		{

		}
	}
}

