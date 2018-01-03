using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotation : MonoBehaviour {
    public GameObject batteryRender; 
    float speed = 5;


    /*
    void FixedUpdate()
    {
        Quaternion startingDifference = testController.transform.rotation * Quaternion.Inverse(testObject.transform.rotation);
        Quaternion relativeDifference = attachedWand.transform.rotation * Quaternion.Inverse(testController.transform.rotation);
        transform.rotation = relativeDifference * testObject.transform.rotation;
    }
    */

    void OnMouseDrag()
    {


        float rotx = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
        float roty = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;


        batteryRender.transform.RotateAround(Vector3.up, -rotx);
        batteryRender.transform.RotateAround(Vector3.right, roty);
    }



    /*
    Quaternion relativeDifference = attachedWand.transform.rotation * Quaternion.Inverse(testController.transform.rotation);
             transform.rotation = relativeDifference * testObject.transform.rotation; 

    */

    /*
    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
                {
                transform.Rotate(0f,touch.deltaPosition.x, 0f);
                }
        }
    */
}


