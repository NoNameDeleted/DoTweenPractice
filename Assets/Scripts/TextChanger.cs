using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;
    [SerializeField] private string _massage;
    [SerializeField] private float _duration;

    private Text _textMesh;

    private void Awake()
    {
        _textMesh = GetComponent<Text>();
    }

    private void Start()
    {
        _textMesh.DOText(_massage, _duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
