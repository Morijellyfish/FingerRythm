using System;
using System.IO;
using System.Linq;
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
        if (Input.GetKeyDown(KeyCode.S))
        {
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
    public static int[] ReadFile()
    {
        string humen = File.ReadAllText(@".\test.txt");
        var SplitedHumen = (humen.Split(','));
        int[] ans= new int[SplitedHumen.Length];
        int i = 0;
        foreach(var s in SplitedHumen)
        {
            if (s!="")
            {
                ans[i] = int.Parse(s);
            }
            i++;
        }
        Debug.Log(ans[1]);
        return ans;
    }
}
