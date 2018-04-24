using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class objectTutorialScript : MonoBehaviour {

    int step = 1;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;

    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;
    public GameObject Scene5;
    public GameObject Scene6;
    public GameObject Scene7;
    public GameObject Scene8;
    public GameObject Scene9;
    public GameObject Scene10;



    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(step);
	if (step == 1)
	{
		Scene1.SetActive(true);
	}
        else if (step == 2)
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
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
        }
        else if (step == 5)
        {
          
            Scene4.SetActive(false);
            Scene5.SetActive(true);
        }
        else if (step == 6)
        {
            button1.SetActive(false);
            button2.SetActive(true);
            Scene5.SetActive(false);
            Scene6.SetActive(true);
        }
        else if (step == 7)
        {
            Scene6.SetActive(false);
            Scene7.SetActive(true);
            button2.SetActive(false);
            button3.SetActive(true);
        }
        else if (step == 8)
        {
            Scene7.SetActive(false);
            Scene8.SetActive(true);
            button3.SetActive(false);
            button4.SetActive(true);
        }
        else if (step == 9)
        {
            Scene8.SetActive(false);
            Scene9.SetActive(true);
        }
        else if (step == 10)
        {
            Scene9.SetActive(false);
            Scene10.SetActive(true);
            button4.SetActive(false);
            button5.SetActive(true);
        }
        else if (step == 11)
        {

            SceneManager.LoadScene("objectMenu");
        }
    }

    public void Continue() {
        Debug.Log("button pressed");
        step++; 
    }
}
