using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManage : MonoBehaviour
{
    Color TapColor=new Color(1,1,1,1);
    Color NormalColor=new Color(1,1,1,0.5f);
    [SerializeField] KeyCode key;
    [SerializeField] GameObject Line;
    [SerializeField] GameObject HitEff;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(key))
        {
            GetComponent<SpriteRenderer>().color = TapColor;
            if (Line.transform.childCount != 0)
            {
                GameObject obj= Line.transform.GetChild(0).gameObject;
                var i = Math.Abs(obj.transform.localPosition.y);
                if (i <= 0.2)
                {
                    Debug.Log("Good");
                    Score.score += 2;
                    Destroy(obj);
                    Instantiate(HitEff, transform.position, transform.rotation);
                }else if (i < 0.4)
                {
                    Debug.Log("Bad");
                    Score.score += 1;
                    Destroy(obj);
                    Instantiate(HitEff, transform.position, transform.rotation);
                }

                
            }

        }

        if (!Input.GetKey(key))
        {
            GetComponent<SpriteRenderer>().color = NormalColor;
        }
    }
}
