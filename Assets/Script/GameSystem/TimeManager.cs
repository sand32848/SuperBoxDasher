using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public float timer;
    public static event Action<float> timerUpdate;
    public static event Action timeOut;
	private bool isTicking = false;

	private void OnEnable()
	{
		GameManager.callWinPre += stopTimer;
		Red.redHitPre += stopTimer;
		PlayerDash.playerDashing += startTimer;
	}

	private void OnDisable()
	{
		GameManager.callWinPre -= stopTimer;
		Red.redHitPre -= stopTimer;
		PlayerDash.playerDashing -= startTimer;
	}

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

	public void startTimer()
	{
		isTicking = true;
	}
}
