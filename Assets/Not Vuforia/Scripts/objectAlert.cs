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
    public GameObject wheel;
    public GameObject gear;

    void Start()
    {
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
            if (mTrackableBehaviour.TrackableName == "battery")
            {
                drill.gameObject.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "omni")
            {
                omni.gameObject.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "Gear1" || mTrackableBehaviour.TrackableName == "Gear1Bottom")
            {
                omni.gameObject.SetActive(true);
            }
            if (mTrackableBehaviour.TrackableName == "hexwheel1")
            {
                omni.gameObject.SetActive(true);
            }
        }
        else
        {
            drill.gameObject.SetActive(false);
            alertModel.gameObject.SetActive(false);
            searchModel.gameObject.SetActive(true);
            na.gameObject.SetActive(true);
            omni.gameObject.SetActive(false);
        }
    }
}