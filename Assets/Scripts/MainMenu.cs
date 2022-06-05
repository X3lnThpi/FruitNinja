using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startGame;

    private void Start()
    {
        startGame.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
