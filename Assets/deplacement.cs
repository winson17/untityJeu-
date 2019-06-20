using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deplacement : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
            Rigidbody r = GetComponent<Rigidbody>();
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Transform>().Rotate(new Vector3(0, 1, 0));
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Transform>().Rotate(new Vector3(0, -1, 0));
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                r.AddForce(-GetComponent<Transform>().right * Speed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                r.AddForce(GetComponent<Transform>().right * Speed);
            }
            if (Input.GetKeyDown("space"))
            {
                r.AddForce(new Vector3(0, 500, 0));
            }

        
    }
}
