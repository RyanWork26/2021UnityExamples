﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsEventTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }
}
