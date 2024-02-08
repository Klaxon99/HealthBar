using UnityEngine;
using TMPro;

public class TextHealthView : HealthView
{
    [SerializeField] private TMP_Text _fill;
    [SerializeField] private TMP_Text _fullVolume;

    public override void DrawHealth(float health, float maxHealth)
    {
        _fill.text = health.ToString();
        _fullVolume.text = maxHealth.ToString();
    }
}