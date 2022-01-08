using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ball : MonoBehaviour
{
	public static event Action GreenBallHit;
	[SerializeField] private GameObject particle;
    public void hit()
	{
		GreenBallHit?.Invoke();
	    Instantiate(particle, transform.position, Quaternion.identity);
		Destroy(gameObject);
		
	}
}
