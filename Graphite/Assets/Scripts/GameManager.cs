using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Might not even need this class since unity handles all of the updating and game loop stuff. -SZ
/// </summary>
public class GameManager : MonoBehaviour {

    public LevelGenerator boardScript;

    private int level = 3;

    private void Awake()
    {
        boardScript = GetComponent<LevelGenerator>();
        initGame();
    }

    void initGame()
    {
        boardScript.setup(level);
    }
}
