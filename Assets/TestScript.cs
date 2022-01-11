using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestScript : MonoBehaviour
{
	public SaveData save;
    // Start is called before the first frame update


    public void test()
	{
        SaveData.current.test += 1;
		SaveData.current.OnSave();
	}

	public void load()
	{
		SaveData.current.OnLoad();

		print(SaveData.current.test);
  
	}
}
