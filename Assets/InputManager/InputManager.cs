using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GamePlay.IGameplayActions
{
    private GamePlay gameInput;
    void Start()
    {
        gameInput = new GamePlay();
        gameInput.Gameplay.Enable();

        gameInput.Gameplay.SetCallbacks(this);
    }
    private Action JumpEvent;
    
    // reading input at every step, invoking the coresponding method from the manager
    // Jump is Space
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Jump started");
            ActionManager.OnJumpStarted?.Invoke();
        }
        if (context.performed)
        {
            Debug.Log("Jump performed");
            ActionManager.OnJumpPerformed?.Invoke();
        }
        if (context.canceled)
        {
            Debug.Log("Jump cancelled");
            ActionManager.OnJumpCancelled?.Invoke();
        }
    }
    // Interact is T
    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Interact started");
            ActionManager.OnInteractStarted?.Invoke();
        }
        if (context.performed)
        {
            Debug.Log("Interact performed");
            ActionManager.OnInteractPerformed?.Invoke();
        }
        if (context.canceled)
        {
            Debug.Log("Interact cancelled");
            ActionManager.OnInteractCancelled?.Invoke();
        }
    }
    // Crouch is Tab
    public void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Crouch started");
            ActionManager.OnCrouchStarted?.Invoke();
        }
        if (context.performed)
        {
            Debug.Log("Crouch performed");
            ActionManager.OnCrouchPerformed?.Invoke();
        }
        if (context.canceled)
        {
            Debug.Log("Crouch cancelled");
            ActionManager.OnCrouchCancelled?.Invoke();
        }
    }

    private void OnEnable()
    {

    }
    private void OnDisable()
    {
        gameInput.Gameplay.Disable();
    }
}
