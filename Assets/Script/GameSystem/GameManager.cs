using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
	int ballCount;
	public static event Action callWinPre;
	public static event Action callWin;
	public static event Action killPlayer;
	public static event Action pause;

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
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
		Time.timeScale = 1;
	}

	void Update()
    {
		if (InputController.Instance && InputController.Instance.ESC)
		{
			if (Time.timeScale == 0)
			{
				InputController.Instance.enableInput();
				Time.timeScale = 1;
			}
			else
			{
				InputController.Instance.disableInput();
				Time.timeScale = 0;
			}
			
			pause?.Invoke();
		}
		CheckBallCount();
    }

	public void CheckBallCount()
	{
		if(ballCount <= 0)
		{
			InputController.Instance.inputActions.Disable();
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
		callWinPre?.Invoke();
		yield return new WaitForSeconds(0.5f);
		callWin?.Invoke();
	}
}
