using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideShowByClick : MonoBehaviour {
    Image ghost;

	// Use this for initialization
	void Start () {
        ghost = GameObject.Find("GhostImage").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (ghost.enabled == true)
            ghost.enabled = false;
        else
            ghost.enabled = true;
    }
}
