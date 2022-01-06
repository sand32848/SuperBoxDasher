using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    public float timer;
    public static event Action<float> timerUpdate;
    public static event Action killPlayer;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timerUpdate != null)
		{
            timerUpdate(timer);
        }

        if(timer <= 0)
		{
            InputController.Instance.disableInput();

            killPlayer?.Invoke();
		}
	
      
    }
}
