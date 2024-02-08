using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthView
{
    [SerializeField] private Slider _slider;

    public override void DrawHealth(float currentHealth, float maxHealth)
    {
        _slider.value = currentHealth / maxHealth;
    }
}