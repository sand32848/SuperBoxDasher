using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
	int ballCount;
	public static event Action callWin;
	public static event Action killPlayer;

	private void OnEnable()
	{
		InputController.Instance.enableInput();
		Ball.GreenBallHit += decraseBallCount;
	}

	private void OnDisable()
	{
		InputController.Instance.disableInput();
		Ball.GreenBallHit += decraseBallCount;
	}
	private void Start()
	{
		DOTween.SetTweensCapacity(2500, 50);
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
		Time.timeScale = 1;
	}

	void Update()
    {
		CheckBallCount();
    }

	public void CheckBallCount()
	{
		if(ballCount <= 0)
		{
			InputController.Instance.disableInput();
			StartCoroutine(winSlowmo());
		}
	}

	public void decraseBallCount()
	{
		ballCount -= 1;
	}

	IEnumerator winSlowmo()
	{
		Time.timeScale = 0.3f;
		yield return new WaitForSeconds(1f);
		callWin?.Invoke();
	}
}
