using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    [SerializeField] private Material _redMaterial;
    [SerializeField] private Material _blueMaterial;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        PlayerTest.TriggerRed += SetColorRed;
        PlayerTest.TriggerBlue += SetColorBlue;
    }

    private void OnDisable()
    {
        PlayerTest.TriggerRed -= SetColorRed;
        PlayerTest.TriggerBlue -= SetColorBlue;
    }

    private void SetColorRed()
    {
        _renderer.material = _redMaterial;
    }

    private void SetColorBlue(bool value)
    {
        if (value)
        {
            _renderer.material = _blueMaterial;
        }
    }
}
