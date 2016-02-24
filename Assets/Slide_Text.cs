using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Slide_Text : MonoBehaviour {

    public List<RectTransform> rekts;
    
    private Vector3[] Top_pos= new Vector3[6];
    private Vector3[] Bot_pos = new Vector3[6];
    private float move = 0f;
	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < 6; i++)
        {
            Top_pos[i] = new Vector3(0,30 * i,0);
            Debug.Log("i : " + i);
            Debug.Log("Test\n");
            Bot_pos[i] = new Vector3(0, - (150 + 35 * i), 0);
        }
        
	}
    public void Reset()
    {
        move = 0f;
    }
       
	// Update is called once per frame
	void FixedUpdate () 
    {
        Debug.Log(move);
        move += move > 1 ? 0 : (0.02f);
        for (int i = 0; i < 6; i++)
        {
            rekts[i].anchoredPosition = Vector3.Lerp(Top_pos[i], Bot_pos[i], move);
            rekts[i].anchoredPosition = new Vector3(0,rekts[i].position.y,0);
        }
	}
}
