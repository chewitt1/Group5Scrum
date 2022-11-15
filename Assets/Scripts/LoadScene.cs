using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// [System.Serializable]
public class LoadScene : MonoBehaviour
{

    public string scene;

    public void StartGame()
    {
        // SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(scene);

    }
}