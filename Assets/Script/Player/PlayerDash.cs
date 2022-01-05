using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using DG.Tweening;


public class PlayerDash : MonoBehaviour
{
	[SerializeField] private float DashTime;
	[SerializeField] private LayerMask layerMask;
	private PlayerAction playerInputActions;
	private Camera mainCam;
	private InputController inputController;
	private bool isAiming = false;
	private LineRenderer lineRenderer;

	private void Start()
    {
		mainCam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
		inputController = GetComponent<InputController>();
		lineRenderer = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		Dash();
	}

    public void Dash()
	{
		Vector2 mousePosition = mainCam.ScreenToWorldPoint(inputController.mousePos);

		Vector2 aimPos = (mousePosition - (Vector2)transform.position).normalized;

		RaycastHit2D hit = Physics2D.Raycast(transform.position, aimPos, 50000, layerMask);

		if (inputController.LeftHold)
		{
			isAiming = true;
			lineRenderer.enabled = true;
		
			
			if(hit.collider != null)
			{
				lineRenderer.SetPosition(0, transform.position);
				lineRenderer.SetPosition(1, hit.point);
			}
		}

		if(!inputController.LeftHold && isAiming)
		{
			lineRenderer.enabled = false;
			isAiming = false;
			transform.DOMove(hit.point,DashTime).SetEase(Ease.OutExpo);
			//mousePosition
			StartCoroutine(mainCam.transform.Shake(0.2f, 0.5f));
		}

    }
}


