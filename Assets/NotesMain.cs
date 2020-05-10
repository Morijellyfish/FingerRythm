using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesMain : MonoBehaviour
{
    public static int BPM;
    [SerializeField] GameObject[] Lines;
    [SerializeField] GameObject note;
    // Start is called before the first frame update
    void Start()
    {
        BPM = 92;
        int[] data=Edit_useFile.ReadFile();
        int i = 0;
        for(int r = 0; r < 4; r++)
        {
            i = 0;
            foreach (int y in data)
            {
                if((y & (byte)Mathf.Pow(2,r)) != 0)
                {
                    var obj=Instantiate(note)as GameObject;
                    obj.transform.parent = Lines[r].transform;
                    obj.transform.localPosition = new Vector3(0, -(60.0f / BPM) * 2 * i, 0);
                    obj.transform.rotation = Quaternion.Euler(0, 0, 90 * -r+180);
                }
                i++;

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
