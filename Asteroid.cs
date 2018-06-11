using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    private float speed = 20;

    public Transform tf;

	// Use this for initialization
	void Start ()
    {
        tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        tf.position += tf.up * speed * Time.deltaTime;

        if (transform.position.x > 23 || transform.position.x < -23)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > 16 || transform.position.x < -16)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TankControls other = collision.gameObject.GetComponent<TankControls>();
        if (other)
        {
            Destroy(other.gameObject);
        }
    }
}