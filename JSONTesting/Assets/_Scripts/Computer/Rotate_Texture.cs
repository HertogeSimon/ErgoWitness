﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Texture : MonoBehaviour {

    public float minSpeed;
    public float maxSpeed;

    private float speed;
    private Renderer rend;
    private Vector2 offset = Vector2.zero;
    private float t;
    private float timeBetweenSwitches;

	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();

        timeBetweenSwitches = Random.Range(0f, 3f);

        speed = Random.Range(minSpeed, maxSpeed);

        Invoke("SwitchDirections", timeBetweenSwitches);

    }

    // Update is called once per frame
    void Update ()
    {
        t = Time.deltaTime;

        offset.y = (offset.y + speed * t) % 1;

        //offset.x = (offset.x + speed * t) % 1;

        rend.material.mainTextureOffset = offset;
    }

    private void SwitchDirections()
    {
        timeBetweenSwitches = Random.Range(0f, 3f);

        speed *= -1;

        Invoke("SwitchDirections", timeBetweenSwitches);
    }
}
