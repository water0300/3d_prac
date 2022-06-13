using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterControl))]
public class PlayerInputHandler : MonoBehaviour {
    private CharacterControl playerControl;
    private PlayerInput _playerInput;
    public PlayerInput PlayerInput { 
        get {
            if (_playerInput == null){
                _playerInput = new PlayerInput();
            }
            return _playerInput;
        }
    }
    private void OnEnable() => PlayerInput.Enable();
    private void OnDisable() => PlayerInput.Disable();
    private void Awake(){
        playerControl = GetComponent<CharacterControl>();

        PlayerInput.Player.Move.performed += ctx => MoveEvent(ctx);
        PlayerInput.Player.Dash.performed += ctx => DashEvent(ctx, true);
        PlayerInput.Player.Dash.canceled += ctx => DashEvent(ctx, false);
    }
    private void MoveEvent(InputAction.CallbackContext ctx){
        playerControl.InputAxis = ctx.ReadValue<Vector2>();
    }

    private void DashEvent(InputAction.CallbackContext ctx, bool pressed){
        playerControl.IsDashing = pressed;
    }


}
