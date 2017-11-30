using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotation : MonoBehaviour {

    float speed = 300;

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


          transform.Rotate(Vector3.up, -rotx);
          transform.Rotate(Vector3.right, roty);
      }

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


