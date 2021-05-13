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
    public float up = 10f;
    




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
        if (Input.GetKey("r"))
        {
            transform.Rotate(Vector3.left, -rotate * Time.deltaTime);
        } 
        if (Input.GetKey("f"))
        {
            transform.Rotate(Vector3.left, rotate * Time.deltaTime);
        }
        
    }
}