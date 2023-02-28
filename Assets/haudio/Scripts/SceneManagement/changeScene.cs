using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScene: MonoBehaviour
{
    public string SceneName;
    public void OnClick(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    
    
}