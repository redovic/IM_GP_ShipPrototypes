﻿using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

    public KeyCode key;
    private Ship ship;

    private Rigidbody2D body;
    private GameObject afterBurner;

	// Use this for initialization
	void Start () {
        body = GetComponentInParent<Rigidbody2D>();
        ship = GetComponentInParent<Ship>();
        afterBurner = transform.GetChild(0).gameObject;
        afterBurner.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(key)) {
            body.AddForce(transform.rotation * Vector3.up * ship.thrusterPower);
            afterBurner.SetActive(true);
        } else {
            afterBurner.SetActive(false);
        }
	}
}