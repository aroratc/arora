using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour {

    private string objectName = null;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "objectTutorial")
        {
            objectName = "omni3";
        }
    }
    public string getObj()
    {
        return objectName;
    }
    public void setObj( string obj )
    {
        objectName = obj; 
    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); 
    }
}
