using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class descriptionObject : MonoBehaviour {
    Text descriptionText;
    int step;

	// Use this for initialization
	void Start () {
        descriptionText = GameObject.Find("infoText").GetComponent<Text>();
        step = 1;
    }
	
	// Update is called once per frame
	void Update () {
        switch (step)
        {
            case 1:
                descriptionText.text = "FIND SOMETHING";
                break;
            case 2:
                descriptionText.text = "PRESS [E]";
                if (Input.GetKeyDown(KeyCode.E))
                    step = 3;
                break;
            case 3:
                descriptionText.text = "IT IS WINE!";
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        step = 2;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        step = 1;
    }
}
