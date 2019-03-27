using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBloco : Bloco
{
 	public GameObject comumBlockPrefab;

 	void OnDestroy() {
 		counter--;
 		GameObject comum = Instantiate(comumBlockPrefab, transform.parent);
 		comum.trasform.position = transform.position;
 	}
}
