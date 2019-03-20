using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
		public Text lifes;

    public void ChangeLife(int value)
    {
    	lifes.text = "Lifes: " + value;
    }
}
