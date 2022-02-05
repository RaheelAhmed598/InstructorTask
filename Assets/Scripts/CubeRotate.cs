using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 RotateAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotation of cube by arrow key
        if (Input.GetKey("up"))
        {
            transform.Rotate(Vector3.right, speed);
        }
        if (Input.GetKey("left"))
        { 
            transform.Rotate(Vector3.up, speed); 
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.down, speed);
        }
        if (Input.GetKey("down"))
        {
            transform.Rotate(Vector3.left, speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += new Vector3(1f, 1f, 1f) * 0.002f;
        }
        else 
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
    }   }
}

