using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private Vector3 _rotationTarget;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DORotate(_rotationTarget, _duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
