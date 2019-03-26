using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
		public Text gameTitle;
		float changeTime;

    // Start is called before the first frame update
    void Start()
    {
    	gameTitle = GameObject.Find("GameTitle").GetComponent<Text>();
    }

    void Update()
    {
    	// Debug.Log(Time.time);
    	if (changeTime < Time.time) 
    	{
    		if (gameTitle.color == Color.white) {
    			gameTitle.color = new Color(1 ,0.6f, 0);
    			} else {
    				gameTitle.color = Color.white;
    			}
    		changeTime = Time.time + 0.5f;
    	}
    }
    
    public void PlayGame()
    {
    	SceneManager.LoadScene(1);
    }

}
