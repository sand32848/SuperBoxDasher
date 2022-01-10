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
    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = GetComponent<SceneLoader>();
        for(int i = 0; i <  buttonSorter.transform.childCount; i++)
		{
            int buttonNumber = i;
            buttonSorter.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = (i +1).ToString();
            buttonSorter.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => sceneLoader.loadScene("Level_" + (buttonNumber +1).ToString())) ;
            //
        }
    }



   
}
