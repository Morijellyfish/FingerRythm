using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMain : MonoBehaviour
{
    [SerializeField] GameObject missEff;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 2*Time.deltaTime, 0);
        if (transform.localPosition.y >= 0.4f)
        {
            Instantiate(missEff,transform.position,transform.rotation);
            Destroy(this.gameObject);
            Debug.Log("miss");
        }
    }
}
