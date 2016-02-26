using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Menu : MonoBehaviour {
    public Back backer;
    public GameObject gameobj;
    public bool main;
    public GameObject parent;
	// Use this for initialization
	void Start () 
    {
        Debug.Log("I started");
        gameobj.active = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void Clicked()
    {
        Debug.Log("I clicked\n");
        if (!gameobj.active)
            backer.Push(gameobj);
        else
            backer.Pop();
        gameobj.active = !gameobj.active;
        parent.active = main;
    }
}
