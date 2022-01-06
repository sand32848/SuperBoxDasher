using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using DG.Tweening;

public class InputController : MonoBehaviour
{
    public static InputController _instance;
    public static InputController Instance => _instance;

    public PlayerAction inputActions;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        inputActions = new PlayerAction();
    }
    private void OnEnable()
    {
        inputActions.Enable();
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

    public Vector2 movement => inputActions.PlayerControl.PlayerMovement.ReadValue<Vector2>();
    public bool LeftHold => inputActions.PlayerControl.LeftHold.ReadValue<float>() > 0.1f;
    public Vector2 mousePos => inputActions.PlayerControl.MousePos.ReadValue<Vector2>();
    public bool R => inputActions.PlayerControl.Restart.triggered;

    //public float RightHold => inputActions.PlayerControl.RightHold.ReadValue<float>();
    //public bool LeftClick => inputActions.PlayerControl.LeftClick.triggered;
    //public bool RightClick => inputActions.PlayerControl.RightClick.triggered;
    //public bool ESC => inputActions.PlayerControl.ESC.triggered;
    //public bool Spacebar => inputActions.PlayerControl.Spacebar.triggered;
    //public bool Console => inputActions.PlayerControl.Console.triggered;

    //public void EnableMouseLook() => inputActions.PlayerControl.MouseLook.Enable();

    //public void DisableMouseLook() => inputActions.PlayerControl.MouseLook.Disable();

    public void enableInput()
	{
        inputActions.Enable();
	}

    public void disableInput()
	{
        inputActions.Disable();
    }
}
