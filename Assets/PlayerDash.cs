using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;


public class PlayerDash : MonoBehaviour
{
    private PlayerAction playerInputActions;
    private float d = 2;

	private void Awake()
	{
        playerInputActions = new PlayerAction();
	}
	private void OnEnable()
    {
        playerInputActions.PlayerControl.DashStart.performed += DashStart;
        playerInputActions.PlayerControl.DashRelease.performed += DashRelease;

        playerInputActions.PlayerControl.DashRelease.Enable();
        playerInputActions.PlayerControl.DashStart.Enable();
    }

	private void OnDisable()
	{
        playerInputActions.PlayerControl.DashStart.performed -= DashStart;
        playerInputActions.PlayerControl.DashRelease.performed -= DashRelease;

        playerInputActions.PlayerControl.DashStart.Disable();
        playerInputActions.PlayerControl.DashRelease.Disable();
    }

	private void Start()
    {
      
    }
    // Start is called before the first frame update
    public void DashStart(InputAction.CallbackContext obj)
    {
        print("F");
    }

    public void DashRelease(InputAction.CallbackContext obj)
    {
        print("F");
    }
}


