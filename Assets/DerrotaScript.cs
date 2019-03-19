using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             // Set the variable type
	int hit_times = 0;
	bool isGoingUp = true;

	void Start() 
	{
		rb = GetComponent<Rigidbody2D>(); 
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

	}
}

