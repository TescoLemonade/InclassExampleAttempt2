using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeToScene(string targetSceneName)
    {
        Debug.Log("Changing to scene: " + targetSceneName);
        SceneManager.LoadScene(targetSceneName);
    }
}
