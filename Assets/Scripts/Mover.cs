using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private float _distance;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMoveZ(_distance, _duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
