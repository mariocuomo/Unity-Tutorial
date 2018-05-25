using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightButton : MonoBehaviour {

    Text textWritten;

	// Use this for initialization
	void Start () {
        textWritten = GameObject.Find("detectionText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (this.gameObject.name == "rightButton")
            textWritten.text ="YOU HAVE CLICKED THE RIGHT BUTTON";
        if (this.gameObject.name == "wrongButton")
            textWritten.text = "YOU HAVE CLICKED THE WRONG BUTTON";
    }
}
