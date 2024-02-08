using UnityEngine;
using UnityEngine.UI;

public class HealthBar : HealthView
{
    [SerializeField] private Slider _slider;

    private float _percent = 0.01f;

    public override void DrawHealth(float health)
    {
        _slider.value = health * _percent;
    }
}