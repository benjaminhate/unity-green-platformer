using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementManager : MonoBehaviour
{
    public InputActionAsset test2;
    public PlayerMovement inputs;
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 40f;
    
    private float m_HorizontalMove;
    private bool m_Crouch;
    private bool m_Jump;

    private void OnEnable()
    {
//        inputs.Enable();
        test2.Enable();
    }

    private void OnDisable()
    {
//        inputs.Disable();
        test2.Disable();
    }

    private void Awake()
    {
//        inputs.Movement.Horizontal.performed += OnHorizontal;
//        inputs.Movement.Jump.performed += OnJump;
//        inputs.Movement.Crouch.performed += OnCrouch;

        test2["Horizontal"].performed += OnHorizontal;
        test2["Jump"].performed += OnJump;
        test2["Crouch"].performed += OnCrouch;
    }

    private void OnHorizontal(InputAction.CallbackContext context)
    {
        m_HorizontalMove = context.ReadValue<float>() * runSpeed;
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        m_Jump = context.started;
    }

    private void OnCrouch(InputAction.CallbackContext context)
    {
        if (context.started)
            m_Crouch = true;
        if (context.canceled)
            m_Crouch = false;
    }

    private void FixedUpdate()
    {
        controller.Move(m_HorizontalMove * Time.fixedDeltaTime, m_Crouch, m_Jump);
        m_Jump = false;
    }
}
