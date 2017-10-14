using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.Find("Player") != null)
		{
			transform.position = new Vector3
			(
				GameObject.Find("Player").transform.position.x,
				GameObject.Find("Player").transform.position.y,
				GameObject.Find("Player").transform.position.z
			);
		}
	}
}
