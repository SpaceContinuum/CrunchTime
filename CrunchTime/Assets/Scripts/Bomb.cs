﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed;    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Activatable" || other.tag == "Back")
        {
            Destroy(gameObject);
        }
        
    }


}
