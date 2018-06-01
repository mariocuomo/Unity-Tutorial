using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour {
    float timer;
    Scrollbar scrollbar;
    Text loadingText;

	// Use this for initialization
	void Start () {
        timer = 5f;
        scrollbar = GameObject.Find("loadingBar").GetComponent<Scrollbar>();
        loadingText = GameObject.Find("percentageText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        scrollbar.size = timer / 5;
        loadingText.text = (timer / 5 * 100).ToString("00") + "%";
	}
}
