using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public float timer;
    public static event Action<float> timerUpdate;
    public static event Action killPlayer;
	private bool isTicking = true;

	private void OnEnable()
	{
		GameManager.callWin += stopTimer;
	}

	private void OnDisable()
	{
		GameManager.callWin -= stopTimer;
	}

	// Update is called once per frame
	void Update()
    {
		if (isTicking)
		{
			timer -= Time.deltaTime;
		}

		timerUpdate?.Invoke(timer);

  //      if(timerUpdate != null)
		//{
  //          timerUpdate(timer);
  //      }

        if(timer <= 0)
		{
            InputController.Instance.disableInput();

            killPlayer?.Invoke();
		}
    }

	public void stopTimer()
	{
		isTicking = false;
	}
}
