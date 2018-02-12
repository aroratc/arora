using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class objectAlert : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public GameObject alertModel;
    public GameObject searchModel;
    public GameObject na;
    public GameObject drill;
    public GameObject omni;
<<<<<<< HEAD
    public GameObject instructions;
=======
    public GameObject wheel;
    public GameObject gear;
    public GameObject thing;
    public GameObject gearbox; 
>>>>>>> 5d889464025a2203164fd896790a380866f94d00



    public GameObject omniObject;
    public GameObject batteryObject;
    Renderer rendOmni;
    Renderer rendBattery; 
    void Start()
    {
        rendOmni = omniObject.GetComponent<Renderer>();
        rendBattery = batteryObject.GetComponent<Renderer>();
        instructions.gameObject.SetActive(false);
        alertModel.gameObject.SetActive(false);
        searchModel.gameObject.SetActive(true);
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
    TrackableBehaviour.Status previousStatus,
    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
        newStatus == TrackableBehaviour.Status.TRACKED ||
        newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("object detected!");
            alertModel.gameObject.SetActive(true);
            searchModel.gameObject.SetActive(false);
            na.gameObject.SetActive(false);
            instructions.gameObject.SetActive(true);
            if (mTrackableBehaviour.TrackableName == "battery")
            {
                drill.gameObject.SetActive(true);
                rendOmni.enabled = false;
                rendBattery.enabled = true;
            }
            else if (mTrackableBehaviour.TrackableName == "omni3")
<<<<<<< HEAD
            {
                omni.gameObject.SetActive(true);
                rendOmni.enabled = true;
                rendBattery.enabled = false;

=======
            {
                omni.gameObject.SetActive(true);

            }
            else if (mTrackableBehaviour.TrackableName == "Gear1" || mTrackableBehaviour.TrackableName == "Gear1Bottom")
            {
                gear.gameObject.SetActive(true);

            }
            else if (mTrackableBehaviour.TrackableName == "hexwheel1")
            {
                wheel.gameObject.SetActive(true);

            }
            else if (mTrackableBehaviour.TrackableName == "thing")
            {
                thing.gameObject.SetActive(true);
            }
            else if (mTrackableBehaviour.TrackableName == "gearbox")
            {
                gearbox.gameObject.SetActive(true);
>>>>>>> 5d889464025a2203164fd896790a380866f94d00
            }
        }
        else
        {

            alertModel.gameObject.SetActive(false);
            searchModel.gameObject.SetActive(true);
            na.gameObject.SetActive(true);
            drill.gameObject.SetActive(false);
            omni.gameObject.SetActive(false);
<<<<<<< HEAD
            instructions.gameObject.SetActive(false);
            rendBattery.enabled = false;
            rendOmni.enabled = false;

=======
            gear.gameObject.SetActive(false);
            wheel.gameObject.SetActive(false);
>>>>>>> 5d889464025a2203164fd896790a380866f94d00
        }
    }
}
