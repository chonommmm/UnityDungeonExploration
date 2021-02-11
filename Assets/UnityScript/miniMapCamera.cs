﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class miniMapCamera : MonoBehaviour
{
    [SerializeField] Transform playertransform = null;
    Vector3 offset = new Vector3(1,0,1);
    [SerializeField] float height = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = new Vector3(playertransform.position.x,height,playertransform.position.z);
    }
    
}
