using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;


public class SceneLoader : MonoBehaviour
{
	public static event Action<string> transition;
	public void Start()
	{
		Time.timeScale = 1;
	}

	public void loadNextScene()
	{
		string resultString = Regex.Match(SceneManager.GetSceneAt(0).name, @"\d+").Value;
	
		string levelString = "Level_" + (int.Parse(resultString) + 1).ToString();

		if (Application.CanStreamedLevelBeLoaded(levelString))
		{
			Time.timeScale = 1;
			transition?.Invoke(levelString);
		}
	}

	public void loadCurrentScene()
	{
		Time.timeScale = 1;
		transition?.Invoke(SceneManager.GetSceneAt(0).name);
		//SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}

	public void loadScene(string sceneName)
	{
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			Time.timeScale = 1;
			transition?.Invoke(sceneName);
		}

	}

}
