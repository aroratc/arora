using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartRot : MonoBehaviour {

    public GameObject battery;
    public GameObject omni;
    public GameObject roller;
    public GameObject frame; 
    private Quaternion batteryStart;
    private Quaternion omniStart;
    private Quaternion rollerStart;
    private Quaternion frameStart;
    // Use this for initialization
    void Start () {
        batteryStart = battery.transform.rotation;
        omniStart = omni.transform.rotation;
        rollerStart = roller.transform.rotation;
        frameStart = frame.transform.rotation;
    }

    // Update is called once per frame
    public void reset()
    {
        battery.transform.rotation = batteryStart;
        omni.transform.rotation = omniStart;
        roller.transform.rotation = rollerStart;
        frame.transform.rotation = frameStart;
    }
}
