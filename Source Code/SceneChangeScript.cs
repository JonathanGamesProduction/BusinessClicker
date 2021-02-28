using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScript : MonoBehaviour
{
    public void MenuSceneChange()
    {
        SceneManager.LoadScene(0);
    }
    public void GameSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
