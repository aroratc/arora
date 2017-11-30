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
            // Play audio when target is found
            Debug.Log("object detected!");
            drill.gameObject.SetActive(true);
            alertModel.gameObject.SetActive(true);
            searchModel.gameObject.SetActive(false);
            na.gameObject.SetActive(false);
        }
        else
        {
            // Stop audio when target is lost
            drill.gameObject.SetActive(false);
            alertModel.gameObject.SetActive(false);
            searchModel.gameObject.SetActive(true);
            na.gameObject.SetActive(true);
        }
    }
}