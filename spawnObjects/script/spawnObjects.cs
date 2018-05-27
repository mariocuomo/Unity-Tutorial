using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnObjects : MonoBehaviour {
    public GameObject prefabSpawnObject;
    float timer;
    public Sprite[] sprites;
    float min;
    float max;
    Vector2 objectPosition;
    GameObject Canvas;
    GameObject lastObject;

	// Use this for initialization
	void Start () {
        timer = 3f;
        Canvas = GameObject.Find("Canvas");
        min = 40;
        max = 900;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            objectPosition = new Vector2(Random.Range(min, max), Random.Range(min, max));
            lastObject = Instantiate(prefabSpawnObject, objectPosition, prefabSpawnObject.transform.rotation, Canvas.transform);
            lastObject.GetComponent<Image>().sprite = (Sprite)sprites.GetValue(Random.Range(0, 4));
            timer = 3f;
        }
	}
}
