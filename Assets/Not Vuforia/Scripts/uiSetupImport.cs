using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiSetupImport : MonoBehaviour
{

    public GameObject omni;
    public GameObject battery;
    public GameObject wheel;
    private string objName = null;
    private GameObject empty;

    // Use this for initialization
    void Start()
    {
        empty = GameObject.Find("scriptStore");
        objName = empty.GetComponent<dontDestroy>().getObj();
        if (objName == "omni")
        {
            omni.SetActive(true);
        }
<<<<<<< HEAD
        else if (objName == "tree")
=======
        else if (objName == "hexwheel1")
        {
            wheel.SetActive(true);
        }
        else if (objName == "gear")
>>>>>>> 5d889464025a2203164fd896790a380866f94d00
        {
            //gear.SetActive(true);
            // i couldnt find the gear model, so for now it doesnt do anything. 
        }
        else if (objName == "battery")
        {
            battery.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
