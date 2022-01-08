using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;


public class SceneLoader : MonoBehaviour
{
	public void loadNextScene()
	{
		string resultString = Regex.Match(SceneManager.GetSceneAt(0).name, @"\d+").Value;
	
		string levelString = "Level_" + (int.Parse(resultString) + 1).ToString();

		if (Application.CanStreamedLevelBeLoaded(levelString))
		{
			SceneManager.LoadScene(levelString);
			Time.timeScale = 1;
		}
	}

	public void loadCurrentScene()
	{
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		Time.timeScale = 1;
	}

	public void loadScene(string sceneName)
	{
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			SceneManager.LoadScene(sceneName);
			Time.timeScale = 1;
		}

	}

	private void Update()
	{
		if (InputController.Instance.R)
		{
			loadCurrentScene();

			Time.timeScale = 1;
		}

	}

}
