using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
	private bool invul = false;
	[SerializeField] private GameObject particle;

	private void OnEnable()
	{
		TimeManager.timeOut += Death;
		Red.redHitPre += Death;
		GameManager.callWinPre += inVulOn;

	}

	private void OnDisable()
	{
		Red.redHitPre -= Death;
		TimeManager.timeOut -= Death;
		GameManager.callWinPre -= inVulOn;
	}
	
	public void Death()
	{
		Destroy(gameObject);
		Instantiate(particle, transform.position, Quaternion.identity);
	}

	public  void inVulOn()
	{
		invul = true;
	}


}
