using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiSetup : MonoBehaviour {

    private int mode = 0;
    public GameObject infopanel;
    public GameObject buttonpanel;

    public GameObject roller;
    public GameObject omni;
    public GameObject frame;

    private bool check = false; 

    private string objName = null;
    private GameObject empty;
    // Use this for initialization
    void Start () {
        empty = GameObject.Find("scriptStore");
        objName = empty.GetComponent<dontDestroy>().getObj();
    }
	
	// Update is called once per frame
	public void onExplodePress () {
        if (objName == "omni3")
        {
            if (mode == 1 || mode == 2)
            {
                findChildObject(infopanel, "roller").SetActive(false);
                findChildObject(infopanel, "frame").SetActive(false);
                findChildObject(infopanel, "omni").SetActive(true);
                frame.SetActive(false);
                roller.SetActive(false);
                omni.SetActive(true);
                Debug.Log("test");
                mode = 0;
            }
            else
            {
                if (buttonpanel.activeSelf == false)
                {
                    findChildObject(infopanel, "roller").SetActive(false);
                    findChildObject(infopanel, "frame").SetActive(false);
                    findChildObject(infopanel, "omni").SetActive(false);
                    //infopanel.SetActive(false);
                    omni.SetActive(false);
                }
                else
                {
                omni.SetActive(true);
                }
                buttonpanel.SetActive(!buttonpanel.activeSelf);
            }
        }
    }
    public void onRollerPress() {
        mode = 1;
        //infopanel.SetActive(true);
        buttonpanel.SetActive(false);
        findChildObject(infopanel, "roller").SetActive(true);
        roller.SetActive(true); 
        
    }
    public void onFramePress() {
        mode = 2;
        //infopanel.SetActive(true);
        buttonpanel.SetActive(false);
        findChildObject(infopanel, "frame").SetActive(true);
        frame.SetActive(true);

    }

    public void onDescPress() {
        toggle(infopanel);
        if (objName == "battery")
        {
            findChildObject(infopanel, "battery").SetActive(true); 
        }
        if (objName == "omni3")
        {
            if (check == false)
            {
                findChildObject(infopanel, "omni").SetActive(true);
                check = true;
            }
        }
    }

    private void toggle(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    private GameObject findChildObject(GameObject parent, string name) {
        return parent.transform.Find(name).gameObject;
    }

}
