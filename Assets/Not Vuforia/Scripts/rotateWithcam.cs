using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateWithcam : MonoBehaviour {

    public GameObject baseCamera;
    public GameObject movingObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        movingObject.gameObject.transform.rotation = new Quaternion(0, baseCamera.gameObject.transform.rotation.y, 0, 0);
	}
}
