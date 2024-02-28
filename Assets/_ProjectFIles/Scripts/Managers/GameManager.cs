using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


// Enum for example game states
[Serializable]
public enum GameState
{
    SplashScreen,
    MainMenu,
    Options,
    Paused,
    Running,
    GameOver
}

// GameManager is a persistent singleton class that manages the game
public class GameManager : PersistentSingleton<GameManager>
{
    public GameState CurrentGameState; // current game state
    public bool GameRunning = false; // is the game running?
    public float PlayerScore = 10; // player score

    #region Standard Unity Methods
    void Start()
    {
        Debug.Log("GameManager is running"); // delete this line after testing
        ChangeGameState(GameState.SplashScreen);
    }

    void Update()
    {
        if (GameRunning) ChangeGameState(GameState.Running);
        // Check the current game state
        switch (CurrentGameState)
        {
            case GameState.SplashScreen:
                SplashScreen();
                break;
            case GameState.MainMenu:
                MainMenu();
                break;
            case GameState.Options:
                Options();
                break;
            case GameState.Paused:
                Paused();
                break;
            case GameState.Running:
                Gameplay();
                break;
            case GameState.GameOver:
                GameOver();
                break;
        }
    } // end of update
    #endregion
    private void Gameplay()
    {
        Debug.Log("In gameplay"); // delete this line after testing
    }
    private void GameOver()
    {
        throw new NotImplementedException();
    }
    private void SplashScreen()
    {
        throw new NotImplementedException();
    }
    private void MainMenu()
    {
        throw new NotImplementedException();
    }
    private void Options()
    {
        throw new NotImplementedException();
    }
    private void Paused()
    {
        throw new NotImplementedException();
    }

    // Method to change the game state
    public void ChangeGameState(GameState newGameState)
    {
        CurrentGameState = newGameState;
    }
}
