using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerrotaScript : MonoBehaviour
{	

	Rigidbody2D rb;             // Set the variable type

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

}
