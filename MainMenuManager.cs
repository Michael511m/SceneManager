using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Button startButton;
    void Start()
    {
        startButton.onClick.AddListener(GameManager.Instance.LoadNextScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
