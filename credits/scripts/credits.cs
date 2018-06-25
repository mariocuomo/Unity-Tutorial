using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour {
    float timer;

	// Use this for initialization
	void Start () {
        timer = 20f;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Application.Quit();
	}
}
