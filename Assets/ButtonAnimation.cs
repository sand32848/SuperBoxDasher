using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonAnimation : MonoBehaviour
{
	public void ButtonHover()
	{

		transform.DOScale(1.3f, 0.3f).SetEase(Ease.OutBack).SetUpdate(true);
	}

	public void ButtonExit()
	{
			transform.DOScale(1, 0.3f).SetUpdate(true);

	}
}
