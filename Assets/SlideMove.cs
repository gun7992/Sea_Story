﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
        	transform.Translate(Input.GetTouch(0).deltaPosition[0], 0, 0);
        }
    }
}
