using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasTimer : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI timerText;
	private void OnEnable()
	{
		TimeManager.timerUpdate += updateTimerText;
	}

	private void OnDisable()
	{
		TimeManager.timerUpdate -= updateTimerText;
	}
	public void updateTimerText(float time)
	{
		float _time = Mathf.Clamp(time, 0, 100);
		timerText.text = _time.ToString("f2");

		
	}
}
