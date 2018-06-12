using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countTouch : MonoBehaviour {
    int count;
    Text countText;

	// Use this for initialization
	void Start () {
        count = 0;
        countText = GameObject.Find("countText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        countText.text = count.ToString();
	}

    public void OnClick()
    {
        count++;
    }
}
