using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour {

	private Transform tx;
	private ParticleSystem.Particle[] points;
	private float starDistanceSqr;
	private float starClipDistanceSqr;

	public int starsMax = 100;
	public float starSize = 1.0f;
	public float starDistance = 10.0f;
	public float starClipDistance = 5;


	// Use this for initialization
	void Start ()
	{
		tx = transform;
		starDistanceSqr = starDistance * starDistance;
		starClipDistance = starClipDistance * starClipDistance;

	}

	private void createStars()
	{
		points = new ParticleSystem.Particle[starsMax];

		for (int i = 0; i < starsMax; i++)
		{
			points[i].position = Random.insideUnitSphere * starDistance + tx.position;
			points[i].color = new Color(1, 1, 1, 1);
			points[i].size = starSize;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (points == null) createStars();

		for (int i = 0; i < starsMax; i++)
		{
			if ((points[i].position - tx.position).sqrMagnitude > starDistance)
			{
				points[i].position = Random.insideUnitSphere.normalized * starDistance + tx.position;
			}
			if ((points[i].position - tx.position).sqrMagnitude <= starClipDistance)
			{
				float percent = (points[i].position - tx.position).sqrMagnitude / starClipDistanceSqr;
				points[i].color = new Color(1, 1, 1, 1);
				points[i].size = percent * starSize;
			}
		}

		GetComponent<ParticleSystem>().SetParticles(points, points.Length);
	}
}
