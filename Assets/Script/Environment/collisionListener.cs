using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class collisionListener : MonoBehaviour
{
    public UnityEvent _event;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		_event.Invoke();

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		_event.Invoke();
	}
}
