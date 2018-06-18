using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rightWord : MonoBehaviour {
    string nameOfImage;
    string nameWritten;

    public Sprite dog;
    public Sprite cat;
    public Sprite fish;

    Sprite[] pets;
    Image imageToGuess;

	// Use this for initialization
	void Start () {
        imageToGuess = GameObject.Find("ImageToGuess").GetComponent<Image>();
        nameOfImage = imageToGuess.sprite.name;
        nameWritten = GameObject.Find("TextWritten").GetComponent<Text>().text;
        pets = new Sprite[] { dog, cat, fish };
    }

    // Update is called once per frame
    void Update () {
        nameWritten = GameObject.Find("TextWritten").GetComponent<Text>().text;

	}

    void OnClick()
    {
        if (nameOfImage == nameWritten)
        {
            imageToGuess.sprite = pets[Random.Range(0, 3)];
            nameOfImage = imageToGuess.sprite.name;
            
        }

    }

}
