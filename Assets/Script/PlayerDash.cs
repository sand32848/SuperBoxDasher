using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using DG.Tweening;


public class PlayerDash : MonoBehaviour
{
	[SerializeField] private float DashTime;

	private PlayerAction playerInputActions;
	private Camera mainCam;
	private InputController inputController;
	private bool isAiming = false;
	private bool isCharging = false;

	private void Start()
    {
		mainCam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
		inputController = GetComponent<InputController>();
	}

	private void Update()
	{
		Dash();
	}

    public void Dash()
	{
		Vector2 mousePosition = mainCam.ScreenToWorldPoint(inputController.mousePos);
		
		if (inputController.LeftHold)
		{
			isCharging = true;
			isAiming = true; 
		}

		if(!inputController.LeftHold && isAiming)
		{
			isAiming = false;
			transform.DOMove(mousePosition,DashTime).SetEase(Ease.OutExpo); 
		}

    }
}


