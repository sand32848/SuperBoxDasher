using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RedBall : MonoBehaviour
{
	public static event Action redBallHit;
	[SerializeField] private GameObject particle;
	
	public void hit()
	{
		redBallHit?.Invoke();
		InputController.Instance.disableInput();
	}
}
