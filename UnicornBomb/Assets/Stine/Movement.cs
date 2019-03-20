﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D Rb;
    [Range(0.5f,40f)]
    public float SpeedMod;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Rb.AddForce(Vector2.left * -Input.GetAxis("Horizontal") * SpeedMod, ForceMode2D.Force);
        } 
    }
}
