using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_MarkerSet : MonoBehaviour
{
    [SerializeField] GameObject noteMarker;
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
            mousePos.z = 0;
            if (-3 <= mousePos.y && mousePos.y <= 0&&mousePos.x>=0)
            {
                if (!Check(Edit_HumenData.humen[(int)mousePos.x],(int)Math.Pow(2,(int)Math.Abs(mousePos.y))))
                {
                    noteMarker.transform.rotation = Quaternion.Euler(0, 0, 180 + 90 * mousePos.y);
                    noteMarker.transform.position = mousePos;
                    Instantiate(noteMarker);
                    Edit_HumenData.humen[(int)mousePos.x] += (int)Math.Pow(2, (int)Math.Abs(mousePos.y));
                    Debug.Log(Edit_HumenData.humen[(int)mousePos.x]);
                }
            }
        }
    }
    bool Check(int a,int b)
    {
        return ((b & (byte)a) != 0);
    }
}
