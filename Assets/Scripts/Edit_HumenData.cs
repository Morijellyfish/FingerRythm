using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_HumenData : MonoBehaviour
{
    public static int[] humen;
    // Start is called before the first frame update
    void Start()
    {
        humen = new int[(int)(8 * Edit_Cameramain.BPM * (this.GetComponent<AudioSource>().clip.length / 60))];
        Debug.Log(humen.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
