using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Red : MonoBehaviour
{
	public static event Action redHit;
	public static event Action redHitPre;
	[SerializeField] private GameObject particle;
	[SerializeField] private Collider2D _collider;

	private void OnEnable()
	{
		GameManager.callWinPre += disableHit;
	}

	private void OnDisable()
	{
		GameManager.callWinPre -= disableHit;
	}

	public void callHitCor()
	{
		StartCoroutine(hit());
	}

	IEnumerator hit()
	{
		Time.timeScale = 0.3f;
		InputController.Instance.disableInput();
		redHitPre?.Invoke();
		yield return new WaitForSeconds(0.5f);
		redHit?.Invoke();
	}

	public void disableHit()
	{
		Destroy(gameObject);
		Instantiate(particle,transform.position,Quaternion.identity);
	}
}
