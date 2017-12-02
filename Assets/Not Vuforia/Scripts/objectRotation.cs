using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectRotation : MonoBehaviour {

    float rotSpeed = 5;

    void OnMouseDrag()
      {
          float rotx = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
          float roty = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;


          transform.RotateAround(Vector3.up, -rotx);
          transform.RotateAround(Vector3.right, roty);
      }
