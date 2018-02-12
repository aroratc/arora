using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newMaterialScript : MonoBehaviour {

 
    Renderer rend;
    private GameObject store; 

	// Use this for initialization
	void Start () {
 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   // void OnTouchDown()
   // {
   //     Debug.Log("click");
   //     rend.sharedMaterial = material[1];
   // }
    void OnTouchUp()
    {
<<<<<<< HEAD
     
=======
        rend.sharedMaterial = material[0];
>>>>>>> 5d889464025a2203164fd896790a380866f94d00
        store = GameObject.Find("scriptStore");
        store.GetComponent<dontDestroy>().setObj(this.transform.parent.name);
        SceneManager.LoadScene("objectMenu");
    }
    /*
    void OnTouchStay()
    {
        rend.sharedMaterial = material[1];
    }
    void OnTouchExit()
    {
        rend.sharedMaterial = material[0];
    }
    */
    void OnTouchHold()
    {
  
    }
}
