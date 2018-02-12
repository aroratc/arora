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
    public GameObject instructions;



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
            {
                omni.gameObject.SetActive(true);
                rendOmni.enabled = true;
                rendBattery.enabled = false;

            }
        }
        else
        {

            alertModel.gameObject.SetActive(false);
            searchModel.gameObject.SetActive(true);
            na.gameObject.SetActive(true);
            drill.gameObject.SetActive(false);
            omni.gameObject.SetActive(false);
            instructions.gameObject.SetActive(false);
            rendBattery.enabled = false;
            rendOmni.enabled = false;

        }
    }
}
