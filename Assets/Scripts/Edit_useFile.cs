using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_useFile : MonoBehaviour
{

    string humen="";
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            WriteFile();
        }
    }
    void WriteFile()
    {
        humen = "";
        foreach (int tmp in Edit_HumenData.humen)
        {
            humen += tmp.ToString();
            humen += ",";
        }
        File.WriteAllText(@".\test.txt", humen);

    }
}
