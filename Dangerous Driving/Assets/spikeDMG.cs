﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeDmg : MonoBehaviour
{
    public HealthBar health1;
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
        if (other.CompareTag("Spike")){
            health1.UpdateHealth(-3.0f);
        }
    }
}
