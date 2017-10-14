using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	// Use this for initialization
	void Start()
	{

	}

	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50.0f;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);
	}

	// Update is called once per frame
	void Update()
	{
		
		if (Input.GetKeyDown("joystick button 0"))
		{
			Fire();
		}


		transform.position += transform.forward * Time.deltaTime * 10.0f;
		transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
	}


}
