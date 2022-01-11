using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotate : MonoBehaviour
{
    [SerializeField] private GameObject pivotPoint;
    [SerializeField] private float rotateSpeed;


    // Update is called once per frame
    void Update()
    {
        if(pivotPoint == null)
		{
            return;
		}

        transform.RotateAround(pivotPoint.transform.position, new Vector3(0, 0, 1), rotateSpeed * Time.deltaTime);
    }

    public enum Rotate {Forward,Return }
}
