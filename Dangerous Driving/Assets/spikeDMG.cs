﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDMG : MonoBehaviour
{
    private HealthBar health1;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Spike")){
            health1.UpdateHealth(-3.0f);
        }
    }
}
