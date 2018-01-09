using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newMaterialScript : MonoBehaviour {

    public Material[] material;
    Renderer rend;
    private GameObject store; 

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
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
        rend.sharedMaterial = material[0];
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
    void OnTouchMove()
    {
        rend.sharedMaterial = material[1];
    }
}
