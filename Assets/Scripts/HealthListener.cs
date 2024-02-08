using UnityEngine;

[RequireComponent(typeof(Health))]
public class HealthListener : MonoBehaviour
{
    [SerializeField] HealthView _healthView;

    private Health _health;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.OnHealthChange += HandleChange;
    }

    private void OnDisable()
    {
        _health.OnHealthChange -= HandleChange;
    }

    private void HandleChange(float health)
    {
        _healthView.DrawHealth(health);
    }
}