using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("Masuk ke dalam permainan");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Keluar Permainan");
    }
}
