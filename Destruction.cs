using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public GameObject player;
    public GameObject asteroid;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (player.transform.position.x > 19 || player.transform.position.x < -19)
        {
            Destroy(player);
        }
        if (player.transform.position.x > 12 || player.transform.position.x < -12)
        {
            Destroy(player);
        }
	}
}
