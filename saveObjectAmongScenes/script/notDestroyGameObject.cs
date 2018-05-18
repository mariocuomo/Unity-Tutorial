using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class notDestroyGameObject : MonoBehaviour {
    float timer = 5f;
    Text nameOfScene;
    string currentScene;
    
	// Use this for initialization
	void Start () {
        nameOfScene = GameObject.Find("TextNotDestroy").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        nameOfScene.text = SceneManager.GetActiveScene().name.ToUpper() + ("\n");
        if(timer>0)
            nameOfScene.text += timer.ToString("0").ToUpper();

        if (timer>0)
            timer -= Time.deltaTime;

        if (timer <= 0 && timer>-1)
        {
            Application.LoadLevel("scene2");
            timer = -1;
        }
	}

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
