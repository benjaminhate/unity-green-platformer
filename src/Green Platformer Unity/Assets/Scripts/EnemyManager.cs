using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using UnityExtensions.ScriptableTools.Variables;

public class EnemyManager : MonoBehaviour, IDamageable
{
    public FloatReference initialHealth;
    public float health;
    public Animator animator;
    
    private static readonly int HurtAnimator = Animator.StringToHash("IsHurt");
    private static readonly int DeadAnimator = Animator.StringToHash("IsDead");

    public bool IsDead => health <= 0;
    
    private void Awake()
    {
        health = initialHealth.Value;
    }

    public void Damage(float damage)
    {
        health -= damage;

        animator.SetBool(HurtAnimator, true);
        if (IsDead)
            Death();
    }

    private void Death()
    {
        animator.SetBool(DeadAnimator, true);
    }

    public void OnHurtAnimationEnd()
    {
        animator.SetBool(HurtAnimator, false);
    }

    public void OnDeathAnimationEnd()
    {
        Destroy(gameObject);
    }
}
