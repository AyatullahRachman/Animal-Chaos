using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public void PlayButton()
    {
        //SceneManager = SceneManager.LoadScene();
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Keluar Permainan");
    }
}
