using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using DG.Tweening;

public class InputTaker : MonoBehaviour
{
    private PlayerAction inputActions;
    public InputAction movement { get; set; }
    // Start is called before the first frame update
    void Awake()
    {
        inputActions = new PlayerAction();
    }

	private void OnEnable()
	{
        movement = inputActions.PlayerControl.PlayerMovement;
        movement.Enable();
	}

	private void OnDisable()
	{
        movement.Disable();

    }


    private void FixedUpdate()
	{

	}
}
