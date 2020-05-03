using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public BattleManager battleManagerScript;
    public static GameManager instance = null; // Make GameManager a Singleton
    [HideInInspector] public bool playersTurn = true;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject); // Ensures only one instance of the GameManager exists
        }

        // When we load a new scene, normally all game objects in the heirarchy are destroyed, buy since we want the gamemanager to persist across scenes we call the below method
        DontDestroyOnLoad(gameObject);
        battleManagerScript = GetComponent<BattleManager>();
        battleManagerScript.Init();
        InitGame();
    }

    void InitGame()
    {
        battleManagerScript.StartLevel("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
