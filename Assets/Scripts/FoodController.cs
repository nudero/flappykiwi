﻿using UnityEngine;
using System.Collections;

public class FoodController : MonoBehaviour {

    private Vector3 newPosition;
    private float speed = 2f;

	// Use this for initialization
	void Start () {
        float x = Random.Range(-1f, 1f);
        x = (x < 0) ? -2f : 2f + x;
        float y = Random.Range(-2f, 2f);
        y = (y < 0) ? -2f : 2f + y;
        transform.position = new Vector3(x, y, 0);

        speed = (x < 0) ? speed : -speed;
	}
	
	// Update is called once per frame
	void Update () {
        newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
	}
}
