using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    [SerializeField] private GameObject buttonSorter;
    [SerializeField] private SceneLoader sceneLoader;
    [SerializeField] private List<Sprite> imageList = new List<Sprite>();
    [SerializeField] private Image previewImage;
    // Start is called before the first frame update
    void Start()
    {
		if (!SaveData.current.levelStat.ContainsKey(1))
		{
            SaveData.current.levelStat.Add( 1, true);
        }

        sceneLoader = GetComponent<SceneLoader>();

        for(int i = 0; i <  buttonSorter.transform.childCount; i++)
		{
            var child = buttonSorter.transform.GetChild(i);

			if (SaveData.current.levelStat.ContainsKey(i + 1))
			{
                if (SaveData.current.levelStat[i + 1] == false)
                {
                    child.GetComponent<Button>().interactable = false;
                }
                else
                {
                    child.GetComponent<Button>().interactable = true;
                }
            }
			else
			{
                SaveData.current.levelStat.Add(i + 1, false);
            }

            int buttonNumber = i;
            child.GetChild(0).GetComponent<TextMeshProUGUI>().text = (i +1).ToString();
            child.GetComponent<Button>().onClick.AddListener(() => sceneLoader.loadScene("Level_" + (buttonNumber +1).ToString())) ;
        }
    }

    public void changePreviewImage(int index)
	{
        previewImage.sprite = imageList[index];
	}



   
}
