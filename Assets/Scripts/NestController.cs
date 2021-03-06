﻿using UnityEngine;
using System.Collections;

public class NestController : MonoBehaviour {

    private Vector3 newPosition;
    private float speed = 1f;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(2.8f, 2.8f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
        if (GameLogic.paused)
        {
            return;
        }

        newPosition = transform.position;
        newPosition.y += Time.deltaTime*speed;
        if (newPosition.y <= -4f)
        {
            newPosition.y = -4f;
            speed = -speed;
        } 
        else if (newPosition.y >= 4f)
        {
            newPosition.y = 4f;
            speed = -speed;
        }
        transform.position = newPosition;
	}
}
