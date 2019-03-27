using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBlocks : MonoBehaviour
{
    // Referencia ao prefab dos blocos
		public GameObject block;
		public GameObject superblock;

		public Vector2 genesisBlock;
		
		int actualScene; 
		int level = 0;

    void Start()
    {
        Debug.Log(SceneManager.sceneCount);

    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log("Contador: " + Bloco.counter);
    }

    void blockCreator()
    {
    	int levelLines = Mathf.Clamp(level, 1, 6);
    	for(int column = 0; column < levelLines; column++) {
    		for (int row = 0; row < 5; row++) {
	    		GameObject copia;
	    		if (1 < level/2) copia = Instantiate(superblock, transform);
	    		else copia = Instantiate(block, transform);
	    		Vector2 newPosition = genesisBlock;
	    		newPosition.x += 1.5f * row;
	    		newPosition.y -= 0.8f * column;
	    		copia.transform.position = newPosition;
	    	}	
    	}
    }

    void OnTriggerEnter2D(Collider2D element)
    {
    	if (element.tag == "Bola") {
    		if (Bloco.counter == 0)
    		{
    			Debug.Log("Create blocks");
    			level++;
        	blockCreator();
        	Debug.Log("Spawning");
    		}
    	}
    }
}
