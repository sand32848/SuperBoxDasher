using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
   public void ButtonHover()
	{
		if(Time.timeScale < 1)
		{
			transform.DOScale(1.3f, 0.3f).SetEase(Ease.OutBack).timeScale = 3f;
		}
		else
		{
			transform.DOScale(1.3f, 0.3f).SetEase(Ease.OutBack);
		}
	}

	public void ButtonExit()
	{
		if (Time.timeScale < 1)
		{
			transform.DOScale(1, 0.3f).timeScale = 3f;
		}
		else
		{
			transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
		}

	}
}
