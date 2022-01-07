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
		}
	}

	public void loadCurrentScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void loadScene(string sceneName)
	{
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			SceneManager.LoadScene(sceneName);
		}

	}

}
