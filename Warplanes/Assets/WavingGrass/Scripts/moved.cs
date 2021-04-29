using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moved : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float move = 10f;
    public float rotate = 50f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(-Vector3.forward * move * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, -rotate * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up, rotate * Time.deltaTime);
        }

    }
}