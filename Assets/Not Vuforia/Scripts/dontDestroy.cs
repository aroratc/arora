using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroy : MonoBehaviour {

    private string objectName = null;

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
