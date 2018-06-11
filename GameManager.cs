using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TankControls player;

	// Use this for initialization
	void Start ()
    {
		if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

	}


	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
