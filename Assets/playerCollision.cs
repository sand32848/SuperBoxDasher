using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
	[SerializeField] GameObject particle;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		var c = collision.GetContact(0);

		Vector3 angle = ((Vector2)transform.position - c.point).normalized;

		Instantiate(particle, c.point,Quaternion.LookRotation(angle));
	}
}
