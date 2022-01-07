using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
[ExecuteInEditMode]
public class LevelManager : MonoBehaviour
{
    List<AsyncOperation> sceneToLoad = new List<AsyncOperation>();
    // Start is called before the first frame update

    private void Awake()
    {
        if (Application.isEditor && !Application.isPlaying)
        {
            EditorSceneManager.OpenScene("Assets/Scenes/GameplayUI.unity", OpenSceneMode.Additive);
            EditorSceneManager.OpenScene("Assets/Scenes/CameraPostProcess.unity", OpenSceneMode.Additive);

        }
		else
		{
            if (!SceneManager.GetSceneByName("GameplayUI").isLoaded)
            {
                sceneToLoad.Add(SceneManager.LoadSceneAsync("GameplayUI", LoadSceneMode.Additive));
            }

            if (!SceneManager.GetSceneByName("CameraPostProcess").isLoaded)
            {
                sceneToLoad.Add(SceneManager.LoadSceneAsync("CameraPostProcess", LoadSceneMode.Additive));
            }
        }

    }
}
