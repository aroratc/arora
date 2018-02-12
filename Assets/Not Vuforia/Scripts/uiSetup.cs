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

    public GameObject omniObj;
    public GameObject frameObj;
    public GameObject rollerObj;
    public GameObject batteryObj;

    private bool check = false;
    private bool disableZoom = false;
    private bool currentZoom = false; 

    private string objName = null;
    private GameObject empty;
    // Use this for initialization
    void Start () {
        empty = GameObject.Find("scriptStore");
        objName = empty.GetComponent<dontDestroy>().getObj();
    }

    // Update is called once per frame
    private void Update()
    {
        /*if (currentZoom == true || singleCheck == false)
        {
            setScale();
            infopanel.SetActive(false);
            singleCheck = true;
        }
        else
        {
            setDefault(); 
        }*/

        if (buttonpanel.activeSelf == true)
        {
            disableZoom = true;
        }
        else
        {
            disableZoom = false; 
        }
    }

    public void onExplodePress () {
        if (objName == "omni3" && currentZoom == false)
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
                    infopanel.SetActive(false);
                    disableZoom = true;
                }
                else
                {
                    findChildObject(infopanel, "omni").SetActive(true);
                    infopanel.SetActive(true);
                    omni.SetActive(true);
                    disableZoom = false;
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
        disableZoom = false; 
    }
    public void onFramePress() {
        mode = 2;
        //infopanel.SetActive(true);
        buttonpanel.SetActive(false);
        findChildObject(infopanel, "frame").SetActive(true);
        frame.SetActive(true);
        disableZoom = false;
    }

    public void onZoomPress() {
        if (disableZoom == false)
        {
            currentZoom = !currentZoom;
            if (currentZoom == true)
            {
                setScale();
                //infopanel.SetActive(false);
            }
            if (currentZoom == false)
            {
                setDefault();
            }
        }
    }

    private void setScale() {
        omniObj.transform.localScale *= 2.5f;
        batteryObj.transform.localScale *= 2.5f;
        frameObj.transform.localScale *= 2.5f;
        rollerObj.transform.localScale *= 2.5f;
    }

    private void setDefault() {
        omniObj.transform.localScale /= 2.5f;
        batteryObj.transform.localScale /= 2.5f;
        frameObj.transform.localScale /= 2.5f;
        rollerObj.transform.localScale /= 2.5f;
    }

    public void onDescPress() {
        if (currentZoom == false || currentZoom == true)
        {
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
    }

    private void toggle(GameObject obj)
    {
        obj.SetActive(!obj.activeSelf);
    }

    private GameObject findChildObject(GameObject parent, string name) {
        return parent.transform.Find(name).gameObject;
    }

}
