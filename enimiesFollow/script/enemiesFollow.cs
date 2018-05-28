using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesFollow : MonoBehaviour {

    public Transform player;
    float speed;
    float distanceEnemy;
    float distance;

	// Use this for initialization
	void Start () {
        speed = 5f;
        distanceEnemy = 200f;
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(transform.position, player.transform.position);

        if(distance < distanceEnemy)
        {
            transform.position = Vector2.Lerp(transform.position, player.transform.position, speed/1000);
        }
	}

}
