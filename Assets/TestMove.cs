using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TestMove : MonoBehaviour
{
    [SerializeField] private float moveTime;
    [SerializeField] private Vector3[] newPos;
    [SerializeField] public Ease easeType;
    // Start is called before the first frame update
    void Start()
    {
        Sequence sequence = DOTween.Sequence().SetEase(easeType).SetLoops(int.MaxValue);

        if (newPos.Length == 1)
        {
            transform.DOMove(newPos[0], moveTime).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            for (int i = 0; i < newPos.Length; i++)
            {
                sequence.Append(transform.DOMove(newPos[i], moveTime));
            }
        }
    }

}
