using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour {

    Text timerText;
    float timer;

	// Use this for initialization
	void Start () {
        Advertisement.Initialize("yourIDNumber");
        timer = 5f;
        timerText = GameObject.Find("countdown timer").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0");

        if (timer <= 0)
        {
            Advertisement.Show("video");
            timer = 5f;
        }
	}
}
