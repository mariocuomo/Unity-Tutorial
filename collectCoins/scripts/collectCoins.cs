using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectCoins : MonoBehaviour {
    int counter = 0;
    public Text counterText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (counter < 3)
            counterText.text = "COINS: " + counter.ToString();
        else
            counterText.text = "GREAT WORK PIGGY BANK";

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "coin")
        {
            counter++;
            Destroy(other.gameObject);
        }
    }
}
