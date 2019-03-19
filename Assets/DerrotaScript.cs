using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             // Set the variable type
	int hit_times = 0;
	void Start() 
	{
		rb = GetComponent<Rigidbody2D>(); 
	}
	void OnTriggerEnter2D(Collider2D colisor)
	{
		print(colisao.gameObject.tag);
	}	

	void OnTriggerStay2D(Collider2D colisor)
	{

	}

	void OnTriggerExit2D(Collider2D colisor)
	{

	}

	void Die(int hit_times)
	{
		if (hit_times > 3) {
			if(Time.timeScale == 1)
					Time.timeScale == 0;
			else
				Time.timeScale == 1;
		}
		// freeze game
	}

}
