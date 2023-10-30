using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject canvas;

    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnHowToPlayButton()
    {
        canvas.SetActive(true);
    }

    public void OnBackButton()
    {
        canvas.SetActive(false);
    }
}
