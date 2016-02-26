using UnityEngine;
using System.Collections;

public class Intervenants : MonoBehaviour {

    public bool interessé;

    string nom;
    
    string heure;
    string endroit;

    public Intervenants(string nom, string heure, string endroit)
    {
        this.nom = nom;
        this.heure = heure;
        this.endroit = endroit;
    }


	// Use this for initialization
	void Start ()
    {
    
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
