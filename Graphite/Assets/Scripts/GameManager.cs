using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Hero player;
   
    //This holds a list of all updatable gameobjects in the game except for the player
    public List<GameObject> gameObjects;

	// Use this for initialization
	void Start () {
        gameObjects = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
       
    }
}
