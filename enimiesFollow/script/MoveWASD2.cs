using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD2 : MonoBehaviour
{
    float speed = 100.0f;
    Vector3 move;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.position += move * speed * Time.deltaTime;

    }
}
