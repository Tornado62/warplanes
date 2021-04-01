using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    float Ver, Hor;
    public float Speed = 10;
    
    
    
    
    
    
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
       Hor = Input.GetAxis("Horisontal") * Time.deltaTime * Speed;
       transform.Translate(new Vector3(Hor, 0, Ver));


















    }
}
