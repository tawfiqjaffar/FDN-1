using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Turn_text : MonoBehaviour {
    public Text text1;
	// Use this for initialization
	void Start () 
    {
        text1 = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update () 
    {
        text1.transform.Rotate(Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
	}
}
