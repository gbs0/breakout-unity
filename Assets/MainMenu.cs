using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
		public Text gameTitle;

    // Start is called before the first frame update
    void Update()
    {

    }
    public void PlayGame()
    {
    	SceneManager.LoadScene(1);
    }

}
