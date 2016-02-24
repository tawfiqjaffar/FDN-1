using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Menu : MonoBehaviour {
    public Back backer;
    public GameObject gameobj;
	// Use this for initialization
	void Start () 
    {
        gameobj.active = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void Clicked()
    {
        if (!gameobj.active)
            backer.Push(gameobj);
        else
            backer.Pop();
        gameobj.active = !gameobj.active;
    }
}
