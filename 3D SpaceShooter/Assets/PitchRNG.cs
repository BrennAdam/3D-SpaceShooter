//Sets a random pitch for the attached objects AudioSource
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchRNG : MonoBehaviour
{
	public float lowPitchRange;
	public float highPitchRange;

	// Use this for initialization
	void Start()
	{
		GetComponent<AudioSource>().pitch = Random.Range(lowPitchRange, highPitchRange);
	}

}
