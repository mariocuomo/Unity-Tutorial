using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioManager : MonoBehaviour {
    bool musicActive;
    AudioSource music;
    Text audioText;
    public Sprite musicOn;
    public Sprite musicOff;
    Image musicImage;

	// Use this for initialization
	void Start () {
        musicActive = true;
        music = GameObject.Find("Canvas").GetComponent<AudioSource>();
        audioText = GameObject.Find("soundText").GetComponent<Text>();
        musicImage = GameObject.Find("soundIcon").GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (musicActive == true)
            {
                musicActive = false;
                music.enabled = false;
                audioText.text = "MUSIC OFF";
                musicImage.sprite = musicOff;
            }
            else
            {
                musicActive = true;
                music.enabled = true;
                audioText.text = "MUSIC ON";
                musicImage.sprite = musicOn;
            }
        }
	}
}
