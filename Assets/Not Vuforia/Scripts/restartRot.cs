using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartRot : MonoBehaviour {

    public GameObject battery;
    private Quaternion qstart;
    // Use this for initialization
    void Start () {
        qstart = battery.transform.rotation; 
	}

    // Update is called once per frame
    public void reset()
    {
        battery.transform.rotation = qstart; 
    }
}
