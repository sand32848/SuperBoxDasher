using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SetMovement : MonoBehaviour
{
    private Vector3 startPos ;
    [SerializeField] private float moveTime;
    [SerializeField] private Vector3[] newPos;
    [SerializeField] public Constraint constraint;
    [SerializeField] public Ease easeType;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        for (int i = 0; i < newPos.Length; i++)
        {
            newPos[i].z = startPos.z;
        }

        if (newPos.Length != 0)
		{
            switch (constraint)
            {
                case Constraint.X:
                    for (int i = 0; i < newPos.Length; i++)
                    {
                        newPos[i].x = startPos.x;
                    }
                    break;
                case Constraint.Y:

                    for (int i = 0; i < newPos.Length; i++)
                    {
                        newPos[i].y = startPos.y;
                    }
                
                    break;
                case Constraint.XY:
                    for (int i = 0; i < newPos.Length; i++)
                    {
                        newPos[i].x = startPos.x;
                        newPos[i].y = startPos.y;
                    }
                    break;
            }
        }
       
   

        if (newPos.Length == 1)
		{
            transform.DOMove(newPos[0], moveTime).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
        }
		else
        {
            Sequence sequence = DOTween.Sequence().SetLoops(int.MaxValue, LoopType.Restart);
            for (int i = 0; i < newPos.Length; i++)
			{
                sequence.Append(transform.DOMove(newPos[i], moveTime)).SetEase(easeType);
			}
		}



	}

    public enum Constraint {X,Y, XY, None,  }
}
