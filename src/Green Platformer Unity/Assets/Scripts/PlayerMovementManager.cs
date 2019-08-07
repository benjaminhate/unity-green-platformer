using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementManager : MonoBehaviour
{
    public PlayerInputs inputs;
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 40f;
    
    private float m_HorizontalMove;
    private bool m_Crouch;
    private bool m_Jump;

    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }

    private void Awake()
    {
        inputs = new PlayerInputs();
        inputs.Movement.Horizontal.performed += OnHorizontal;
        inputs.Movement.Jump.started += OnJumpStart;
        inputs.Movement.Crouch.started += OnCrouchStart;
        inputs.Movement.Crouch.canceled += OnCrouchCancel;
    }

    private void OnHorizontal(InputAction.CallbackContext context)
    {
        m_HorizontalMove = context.ReadValue<float>() * runSpeed;
    }

    private void OnJumpStart(InputAction.CallbackContext context)
    {
        m_Jump = true;
    }

    private void OnCrouchStart(InputAction.CallbackContext context)
    {
        m_Crouch = true;
    }
    private void OnCrouchCancel(InputAction.CallbackContext context)
    {
        m_Crouch = false;
    }

    private void FixedUpdate()
    {
        controller.Move(m_HorizontalMove * Time.fixedDeltaTime, m_Crouch, m_Jump);
        if (inputs.Movement.Horizontal.phase != InputActionPhase.Performed)
            m_HorizontalMove = 0f;
        m_Jump = false;
    }
}
