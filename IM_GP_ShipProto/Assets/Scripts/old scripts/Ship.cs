﻿using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
    
    [Range(0, 20)]
    public float thrusterPower;
    [Range(0, 1)]
    public float drag;
    private float maxDrag = 5.0f;

    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.drag = drag;
        rb.angularDrag = drag;
    }

}
