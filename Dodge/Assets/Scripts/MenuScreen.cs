using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuScreen : MonoBehaviour
{
    public GameObject panelStartMenu;
    public void StartButton(){
        panelStartMenu.SetActive(false);
    }

    public void RestartButton(){
        SceneManager.LoadScene("Game");
    }

    public void ExitButton(){
        Application.Quit();
    }
}
