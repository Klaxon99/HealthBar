using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBar : HealthView
{
    [SerializeField] private Slider _slider;
    [SerializeField] private float _changeSpeed;

    private float _percent = 0.01f;
    private Coroutine _coroutine;

    public override void DrawHealth(float health)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangeHealth(health));
    }

    private IEnumerator ChangeHealth(float targetHealth)
    {
        while (_slider.value != targetHealth * _percent)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetHealth * _percent, _changeSpeed * Time.deltaTime);

            yield return null;
        }
    }
}