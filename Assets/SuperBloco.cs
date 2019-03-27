using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBloco : Bloco
{
 	public GameObject comumBlockPrefab;

 	void OnDestroy() {
 		counter--;
 		GameObject comum = Instatiate(comumBlockPrefab, transform.parent);
 	}
}
