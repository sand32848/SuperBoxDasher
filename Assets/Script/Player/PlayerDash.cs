using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using DG.Tweening;
using System;


public class PlayerDash : MonoBehaviour
{
	public static event Action playerDashing;
	[SerializeField] private float DashTime;
	[SerializeField] private LayerMask layerMask;
	[SerializeField] private ParticleSystem particle;
	[SerializeField] private GameObject sprite;
	[SerializeField] private GameObject wallParticle;

	#region resourceRef
	private PlayerAction playerInputActions;
	private Camera mainCam;
	private InputController inputController;
	private LineRenderer lineRenderer;
	private Rigidbody2D rb;
	#endregion

	#region variable
	private bool isAiming = false;
	private float DashCooldown = 0.4f;
	private float _DashCooldown;
	private Vector2 ColliderPos;
	private Vector2 particlePos;
	#endregion


	private void Start()
    {
		_DashCooldown = DashCooldown;
		rb = GetComponent<Rigidbody2D>();
		mainCam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
		inputController = GetComponent<InputController>();
		lineRenderer = GetComponent<LineRenderer>();
	}

	private void Update()
	{
		DashCooldown -= Time.deltaTime;
		Dash();
	}

    public void Dash()
	{
		var emission = particle.emission;
	
		Vector2 mousePosition = mainCam.ScreenToWorldPoint(inputController.mousePos);

		Vector2 aimPos = (mousePosition - (Vector2)transform.position).normalized;

		RaycastHit2D hit = Physics2D.Raycast(transform.position, aimPos, 10000, layerMask);



		if (inputController.LeftClick)
		{
			if(AudioManager.instance != null)
			{
				AudioManager.instance.Play("ChargeUp");
				sprite.transform.DOShakePosition(1, 0.1f, 15, 90,false,false).SetLoops(-1).SetId("Shake");
			}
		}

		if (inputController.LeftHold && DashCooldown <= 0)
		{
			particlePos = hit.point;
			ColliderPos = ((Vector2)transform.position - particlePos).normalized;

			isAiming = true;
			lineRenderer.enabled = true;
			emission.enabled = true;


			if (hit.collider != null)
			{
				lineRenderer.SetPosition(0, transform.position);
				lineRenderer.SetPosition(1, hit.point);
			}
		}

		if(!inputController.LeftHold && isAiming)
		{
			if (AudioManager.instance != null)
			{
				AudioManager.instance.Play("Dash");
			}

			DOTween.Kill("Shake",true);
			DashCooldown = _DashCooldown;
			rb.gravityScale = 18;
			emission.enabled = false;
			lineRenderer.enabled = false;
			isAiming = false;

			transform.DOMove(hit.point,DashTime).SetEase(Ease.OutExpo).SetId("Dash");
			StartCoroutine(mainCam.transform.Shake(0.2f, 1f));
			playerDashing?.Invoke();
		}
    }

	public void KillDash()
	{
		DOTween.Kill("Dash");

		GameObject p = Instantiate(wallParticle,particlePos,Quaternion.LookRotation(ColliderPos));
		Destroy(p, 1);

		StartCoroutine(PlayerFloat());
	}

	IEnumerator PlayerFloat()
	{
		rb.gravityScale = 0;
		yield return new WaitForSeconds(0.3f);
		rb.gravityScale = 18;
	}

}


