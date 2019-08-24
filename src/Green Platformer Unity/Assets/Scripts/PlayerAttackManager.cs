using System;
using Inputs;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityExtensions.ScriptableTools.Variables;

public class PlayerAttackManager : MonoBehaviour
{
    public FloatReference attackDamage;
    public PlayerInputs inputs;
    public float attackRate = 1f;
    public Animator animator;

    private float _lastTimeAttack;
    private bool _swipe;
    private bool _attacking;
    private static readonly int SwipeAnimator = Animator.StringToHash("IsSwiping");

    private void OnEnable()
    {
        inputs.Attack.Enable();
    }

    private void OnDisable()
    {
        inputs.Attack.Disable();
    }

    private void Awake()
    {
        inputs = new PlayerInputs();

        inputs.Attack.Swipe.performed += OnSwipe;

        _lastTimeAttack = Time.time;
    }

    private void OnSwipe(InputAction.CallbackContext context)
    {
        _swipe = true;
    }

    private void Update()
    {
        if (Time.time - _lastTimeAttack > attackRate && _swipe)
        {
            _lastTimeAttack = Time.time;
            _swipe = false;
            _attacking = true;
            animator.SetBool(SwipeAnimator, true);
        }
    }

    public void OnAttackAnimationEnd()
    {
        _attacking = false;
        animator.SetBool(SwipeAnimator, false);
    }
}
