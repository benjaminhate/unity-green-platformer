using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityExtensions.ScriptableTools.Variables;

public class EnemyManager : MonoBehaviour
{
    public FloatReference initialHealth;
    public float health;

    public bool IsDead => health <= 0;
    
    private void Awake()
    {
        health = initialHealth.Value;
    }

    public void Damage(float damage)
    {
        health -= damage;

        if (IsDead)
            Death();
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
