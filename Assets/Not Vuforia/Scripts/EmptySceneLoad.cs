using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptySceneLoad : MonoBehaviour
{

    // Use this for initialization

    public void loadTut()
    {
        SceneManager.LoadScene("tutorial");
    }
}

