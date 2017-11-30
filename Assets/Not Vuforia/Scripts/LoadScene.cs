using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject logo;
    public GameObject menu1;
    public GameObject menu2;

	// Use this for initialization
	public void loadLevel () {
        Debug.Log("button pressed.");
        SceneManager.LoadScene("testScene");
	}
    public void loadMenu()
    {
        Debug.Log("button pressed.");
        SceneManager.LoadScene("mainMenu");
    }
    public void nextMenu()
    {
        Debug.Log("button pressed.");
        menu1.SetActive(false);
        logo.SetActive(false);
        menu2.SetActive(true);
    }
        
}

