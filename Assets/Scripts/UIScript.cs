﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
		public Text lifes;
		public Text time;
        public Text score;
        int scoreValue;
        
        // public Text score;

    public void ChangeLife(int value)
    {
    	lifes.text = "Lifes: " + value;
    }

    public void ChangeScore(int value)
    {
        score.text =  value + "00";
    }

    void Start()
    {
    	// for (int i = 0; i < 61; i++) {
    	// 	// Debug.Log(i);
    	// }
    }

    void Update()
    {

    }
}
