using System.ComponentModel;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class collisionListener : MonoBehaviour
{
    public UnityEvent _event;
	public Layers layers;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == (int)layers)
		{
			_event.Invoke();
		}
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.gameObject.layer == (int)layers)
		{
			_event.Invoke();
		}
	}
	public enum Layers
	{
		None = 0,
		Player = 6,
		Ball = 7,
		Wall = 9
	}

}
