using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public float timer;
    public static event Action<float> timerUpdate;
    public static event Action timeOut;
	private bool isTicking = true;

	private void OnEnable()
	{
		GameManager.callWin += stopTimer;
		RedBall.redBallHit += stopTimer;
	}

	private void OnDisable()
	{
		GameManager.callWin -= stopTimer;
		RedBall.redBallHit -= stopTimer;
	}

	// Update is called once per frame
	void Update()
    {
		if (isTicking)
		{
			timer -= Time.deltaTime;
		}

		timerUpdate?.Invoke(timer);

        if(timer <= 0)
		{
            InputController.Instance.disableInput();

            timeOut?.Invoke();
		}
    }

	public void stopTimer()
	{
		isTicking = false;
	}
}
