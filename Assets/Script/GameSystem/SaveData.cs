using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    private static SaveData _current;
    public static SaveData current {
        get
        {
            if (_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
            set
        {
                if (value != null)
                {
                    _current = value;
                }
            }

    }

    public Dictionary<int, bool> levelStat = new Dictionary<int, bool>();
    public int test = 0;

    public  void OnSave()
	{
        SerializeManager.Save("Save", SaveData.current);
    }

    public void OnLoad()
    {
        SaveData.current = (SaveData)SerializeManager.Load(Application.persistentDataPath + "/saves/Save.save");
    }
}
