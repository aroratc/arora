using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicRotate : MonoBehaviour{

    public LayerMask touchInputMask;
    private List<GameObject> touchList = new List<GameObject>();
    private GameObject[] touchArray;

    private RaycastHit hit;

    public GameObject battery;


    // Use this for initialization
    void Start()
    {
        Camera camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.touchCount > 0)
        {
            Debug.Log("TOUCH DETECTED");
            touchArray = new GameObject[touchList.Count];
            touchList.CopyTo(touchArray);
            touchList.Clear();

            foreach (Touch touch in Input.touches)
            {
                Camera camera = GetComponent<Camera>();
                Ray ray = camera.ScreenPointToRay(touch.position);
       

                if (Physics.Raycast(ray, out hit, touchInputMask))
                {
                    GameObject reciever = hit.transform.gameObject;
                    touchList.Add(reciever);

                    if (touch.phase == TouchPhase.Began)
                    {
                        reciever.SendMessage("OnTouchDown", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Ended)
                    {
                        reciever.SendMessage("OnTouchUp", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Stationary)
                    {
                        reciever.SendMessage("OnTouchStay", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                    if (touch.phase == TouchPhase.Moved)
                    {
                        reciever.SendMessage("OnTouchMoved", hit.point, SendMessageOptions.DontRequireReceiver);
                        
                    }
                    if (touch.phase == TouchPhase.Canceled)
                    {
                        reciever.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }


            foreach (GameObject gameobject in touchArray)
            {
                if (!touchList.Contains(gameobject))
                {
                    gameobject.SendMessage("OnTouchExit", hit.point, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
