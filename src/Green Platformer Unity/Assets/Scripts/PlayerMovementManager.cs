using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementManager : MonoBehaviour
{
    public InputActionAsset inputs;
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
        inputs["Horizontal"].performed += OnHorizontal;
        inputs["Horizontal"].canceled += OnHorizontalCancel;
        inputs["Jump"].started += OnJumpStart;
        inputs["Crouch"].started += OnCrouchStart;
        inputs["Crouch"].canceled += OnCrouchCancel;
    }

    private void OnHorizontal(InputAction.CallbackContext context)
    {
        m_HorizontalMove = context.ReadValue<float>() * runSpeed;
    }
    private void OnHorizontalCancel(InputAction.CallbackContext context)
    {
        m_HorizontalMove = 0f;
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
        m_Jump = false;
    }
}
