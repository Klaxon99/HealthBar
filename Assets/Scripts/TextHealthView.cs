using UnityEngine;
using TMPro;

public class TextHealthView : HealthView
{
    [SerializeField] private TMP_Text _fill;
    [SerializeField] private TMP_Text _fullVolume;

    private int _maxHealth = 100;

    public override void DrawHealth(float health)
    {
        _fill.text = health.ToString();
        _fullVolume.text = _maxHealth.ToString();
    }
}