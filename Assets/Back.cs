using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Back : MonoBehaviour {

    private Stack<GameObject> stack = new Stack<GameObject>();

	// Use this for initialization
	void Start () {
	
	}


    public void Clicked()
    {
        if (stack.Count == 0)
            return;
        GameObject g = stack.Pop();
        g.active = false;
        stack.Peek().active = true;
    }

    public void Push(GameObject g)
    {
        stack.Push(g);
    }

    public void Pop()
    {
        stack.Pop();
    }

	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
