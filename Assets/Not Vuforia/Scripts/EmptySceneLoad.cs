using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptySceneLoad : MonoBehaviour
{
    public GameObject loading;
    // Use this for initialization

    public void loadTutorial()
    {
        loading.SetActive(true);
        StartCoroutine(loadLevelRoutine());
    }

    IEnumerator loadLevelRoutine()
    {
        Debug.Log("send help");
        yield return new WaitForSeconds(0.1f);
        Debug.Log("button pressed.");
        SceneManager.LoadScene("tutorial");
    }
}

