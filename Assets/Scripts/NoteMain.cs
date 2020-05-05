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
        transform.Translate(0, 0.1f, 0);
        if (transform.localPosition.y >= 0.4f)
        {
            missEff.transform.position = this.transform.position;
            missEff.transform.rotation = this.transform.rotation;
            Instantiate(missEff);
            Destroy(this.gameObject);
            Debug.Log("miss");
        }
    }
}
