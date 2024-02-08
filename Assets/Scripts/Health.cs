using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _health;
    private float _maxHealth;
    private float _minHealth;

    public event Action OnDead;
    public event Action<float> OnHealthChange;

    public float Value => _health;
    public bool IsAlive => _health > _minHealth;

    private void Start()
    {
        _maxHealth = 100;
        _minHealth = 0;
        _health = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (damage > 0)
        {
            _health = Mathf.Max(_health - damage, _minHealth);    
            OnHealthChange?.Invoke(_health);
        }

        if (IsAlive == false)
        {
            OnDead?.Invoke();
        }
    }

    public void Recovery(float healthCount)
    {
        if (healthCount > 0)
        {
            _health = Mathf.Min(_health + healthCount, _maxHealth);
            OnHealthChange?.Invoke(_health);
        }
    }
}