using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
	[SerializeField] private GameObject particle;

	private void OnEnable()
	{
		TimeManager.timeOut += Death;
		RedBall.redBallHit += Death;

	}

	private void OnDisable()
	{
		RedBall.redBallHit -= Death;
		TimeManager.timeOut -= Death;
	}
	
	public void Death()
	{
		Destroy(gameObject);
		Instantiate(particle, transform.position, Quaternion.identity);
	}


}
