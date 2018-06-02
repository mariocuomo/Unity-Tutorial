using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class colorVoice : MonoBehaviour
{
    string[] keywords;
    ConfidenceLevel confidence;
    protected PhraseRecognizer recognizer;
    protected string word = "white";

    Image background;

    private void Start()
    {
        confidence = ConfidenceLevel.Low;
        keywords = new string[] { "white", "red", "green", "blue" };
        background = GameObject.Find("background").GetComponent<Image>();
        if (keywords != null)
        {
            recognizer = new KeywordRecognizer(keywords, confidence);
            recognizer.OnPhraseRecognized += Recognizer_OnPhraseRecognized;
            recognizer.Start();
        }
    }

    private void Recognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        word = args.text;
    }

    private void Update()
    {
        
        switch (word)
        {
            case "white":
                background.color = new Color(255f, 255f, 255f);
                break;
            case "red":
                background.color = new Color(255f, 0f, 0f);
                break;
            case "green":
                background.color = new Color(0f, 255f, 0f);
                break;
            case "blue":
                background.color = new Color(0f, 0f, 255f);
                break;
        }

    }

    private void OnApplicationQuit()
    {
        if (recognizer != null && recognizer.IsRunning)
        {
            recognizer.OnPhraseRecognized -= Recognizer_OnPhraseRecognized;
            recognizer.Stop();
        }
    }
}
