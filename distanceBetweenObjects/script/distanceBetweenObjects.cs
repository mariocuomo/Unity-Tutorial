using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distanceBetweenObjects : MonoBehaviour {
    public GameObject object1;
    public GameObject object2;
    public Text TextDistance;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TextDistance.text = Vector3.Distance(object1.transform.position, object2.transform.position).ToString();
    }
}
