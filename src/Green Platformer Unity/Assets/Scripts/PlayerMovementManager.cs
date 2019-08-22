using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementManager : MonoBehaviour
{
    public PlayerInputs inputs;
    [SerializeField] private Animator animator;
    [SerializeField] private CharacterController2D controller;
    [SerializeField] private float runSpeed = 40f;
    
    private float _horizontalMove;
    private bool _crouch;
    private bool _jump;
    private static readonly int SpeedAnimator = Animator.StringToHash("Speed");
    private static readonly int JumpAnimator = Animator.StringToHash("IsJumping");
    private static readonly int CrouchAnimator = Animator.StringToHash("IsCrouching");

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
        _horizontalMove = context.ReadValue<float>() * runSpeed;
    }

    private void OnJumpStart(InputAction.CallbackContext context)
    {
        _jump = true;
    }

    private void OnCrouchStart(InputAction.CallbackContext context)
    {
        _crouch = true;
    }
    private void OnCrouchCancel(InputAction.CallbackContext context)
    {
        _crouch = false;
    }

    private void FixedUpdate()
    {
        controller.Move(_horizontalMove * Time.fixedDeltaTime, _crouch, _jump);
        
        animator.SetFloat(SpeedAnimator, Mathf.Abs(_horizontalMove));
        if(_jump)
            animator.SetBool(JumpAnimator, true);
        
        _jump = false;
    }

    public void OnLanding()
    {
        animator.SetBool(JumpAnimator, false);
    }

    public void OnCrouching(bool crouch)
    {
        animator.SetBool(CrouchAnimator, crouch);
    }
}
