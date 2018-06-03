using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    Transform tf;

    public float rotationSpeed;

	// Use this for initialization
	void Start ()
    {
        tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position -= tf.up;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.up;
        }
    }
}
