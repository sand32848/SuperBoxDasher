using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField] private GameObject particle;
    public void hit()
	{
	   Instantiate(particle, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}
