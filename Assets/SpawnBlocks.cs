using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{
    // Referencia ao prefab dos blocos
		public GameObject block;
		public Vector2 genesisBlock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void blockCreator()
    {
    	for(int column = 0; column < 3; column++) {
    		for (int row = 0; row < 5; row++) {
	    		GameObject copia = Instantiate(block, transform);
	    		Vector2 newPosition = genesisBlock;
	    		newPosition.x += 1.5f * row;
	    		newPosition.y -= 0.8f * column;
	    		copia.transform.position = newPosition;
	    	}	
    	}


    	    	
    }
}
