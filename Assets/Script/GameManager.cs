using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
	int ballCount;
	public static event Action callWin;
	public static event Action killPlayer;

	private void OnEnable()
	{
		Ball.updateBallCount += decraseBallCount;
	}

	private void OnDisable()
	{
		Ball.updateBallCount += decraseBallCount;
	}
	private void Start()
	{
		ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;
	}

	void Update()
    {
		if (InputController.Instance.R)
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
		}

		CheckBallCount();
    }

	public void CheckBallCount()
	{
		if(ballCount <= 0)
		{
			callWin?.Invoke();
		}
	}

	public void decraseBallCount()
	{
		ballCount -= 1;
	}
}
