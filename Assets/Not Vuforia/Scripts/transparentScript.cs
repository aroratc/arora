using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transparentScript : MonoBehaviour {

    int step = 1;
    public GameObject Menus;
    public GameObject BackButton;
    public GameObject InfoPanel;

    public GameObject TouchThing; 

    public GameObject Part1;
    public GameObject Part2;
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject Scene5;
    public GameObject Scene6;
    public GameObject Scene7;
    public GameObject Scene8;



    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (step == 2)
        {
            Scene1.SetActive(false);
            Scene2.SetActive(true);
        }
        else if (step == 3)
        {
            Scene2.SetActive(false);
            Scene3.SetActive(true);
        }
        else if (step == 4)
        {
            Scene3.SetActive(false);
            Scene4.SetActive(true);
        }
        else if (step == 5)
        {
            Scene4.SetActive(false);
            Part1.SetActive(false);
            Part2.SetActive(true);
            Menus.SetActive(true);
            Scene5.SetActive(true);
            TouchThing.SetActive(false);
        }
        else if (step == 6)
        {
            Scene5.SetActive(false);
            BackButton.SetActive(false);
            Scene6.SetActive(true);
        }
        else if (step == 7)
        {
            Scene6.SetActive(false);
            BackButton.SetActive(true);
            InfoPanel.SetActive(false);
            Scene7.SetActive(true);
        }
        else if (step == 8)
        {
            Scene7.SetActive(false);
            BackButton.SetActive(true);
            InfoPanel.SetActive(true);
            Scene8.SetActive(true);
        }
        else if (step == 9)
        {
            SceneManager.LoadScene("objectTutorial");
        }
    }

    public void Continue() {
        Debug.Log("button pressed");
        step++; 
    }
}
