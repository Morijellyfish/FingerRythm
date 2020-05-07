using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_MarkerSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos=Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.x = (float)Math.Round(mousePos.x, MidpointRounding.AwayFromZero);
            mousePos.y = (float)Math.Round(mousePos.y, MidpointRounding.AwayFromZero);
            Debug.Log(mousePos);
        }
    }
}
