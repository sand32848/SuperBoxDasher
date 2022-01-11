using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformParenting : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject);
        col.gameObject.transform.SetParent(gameObject.transform, true);
       
    }
    void OnCollisionExit2D(Collision2D col)
    {
    col.gameObject.transform.parent = null;
    }
}
