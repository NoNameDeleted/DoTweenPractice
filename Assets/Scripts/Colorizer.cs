using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Colorizer : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private Color _colorTarget;
    [SerializeField] private float _duration;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        _renderer.material.DOColor(_colorTarget, _duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
