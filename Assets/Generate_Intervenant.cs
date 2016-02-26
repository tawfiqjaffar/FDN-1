using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

public class Generate_Intervenant : MonoBehaviour {

    public Text origin;
    List<Intervenants> inter = new List<Intervenants>();
	// Use this for initialization
	void Start () 
    {
        string str = File.ReadAllText("Intervenant.txt");
        Debug.Log(str);
        Text text1 = Text.Instantiate<Text>(origin);
        text1.transform.SetParent(transform);
        text1.rectTransform.position = origin.rectTransform.position;
        text1.text = str;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
