using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveValue : MonoBehaviour {
    public Text lastText;
    public Text newText;

	// Use this for initialization
	void Start () {
        lastText.text = PlayerPrefs.GetString("word");
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetString("word", newText.text);
	}
}
