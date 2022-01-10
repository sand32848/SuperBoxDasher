using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SetScale : MonoBehaviour
{
	private void Start()
	{
		transform.DOScale(1.05f,0.5f).SetLoops(-1,LoopType.Yoyo).SetEase(Ease.InCirc);
	}

	public void rotate()
	{

	}
}
