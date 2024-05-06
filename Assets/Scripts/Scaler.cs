using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
