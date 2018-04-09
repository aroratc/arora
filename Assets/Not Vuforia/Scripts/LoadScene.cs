using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject battery; 
    public GameObject logo;
    public GameObject menu1;
    public GameObject menu2;

    private Quaternion qstart;
	// Use this for initialization
    void Start()
    {
        qstart = battery.transform.rotation;
    }

	public void loadLevel () {
        Debug.Log("button pressed.");
        SceneManager.LoadScene("newDetectionScene");
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

    public void loadTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void reset()
    {
        Debug.Log("hey there");
        battery.transform.rotation = qstart;
    }
}

