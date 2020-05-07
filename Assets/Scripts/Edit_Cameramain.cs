using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_Cameramain : MonoBehaviour
{
    [SerializeField] GameObject Lines;
    [SerializeField] GameObject Notes;
    [SerializeField] int BPM;
    bool playing;
    AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = Notes.GetComponent<AudioSource>();
        AudioSource.time = 0;
        playing = true;
        
        for(int i = 0; i < BPM; i++)
        {
            Lines.transform.position = new Vector2(i * 6, Lines.transform.position.y);
            Instantiate(Lines);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if (playing)
            {
                playing = false;
                AudioSource.Stop();
            }
            else
            {
                if (transform.position.x >= 0)
                {
                    AudioSource.time = transform.position.x / 6 * (60.0f / BPM);
                    AudioSource.Play();
                }
                playing = true;
            }
        }

        if (playing) {
            //6を掛けるのは1拍を６等分してノーツを置けるようにしているため
            transform.Translate(Time.deltaTime*6/(60.0f / BPM), 0, 0);
            if (!AudioSource.isPlaying&&transform.position.x>=0)
            {
                AudioSource.time = transform.position.x / 6 * (60.0f / BPM);
                AudioSource.Play();
            }
        }
        else
        {
            var x_input = Input.GetAxis("Horizontal");
            transform.Translate(x_input / 2, 0, 0);
        }
    }
}
