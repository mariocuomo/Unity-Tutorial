using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownManager : MonoBehaviour {
    Text timerText;
    private float timerNumber;

	// Use this for initialization
	void Start () {
        timerNumber = 60f;
        timerText = GameObject.Find("timer").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timerNumber -= Time.deltaTime;
        timerText.text = timerNumber.ToString("00.00");

        if(timerNumber<=0)
        {
            //do something
        }
	}
}
