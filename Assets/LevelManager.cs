using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    List<AsyncOperation> sceneToLoad = new List<AsyncOperation>();
    // Start is called before the first frame update
    void Start()
    {
        sceneToLoad.Add(SceneManager.LoadSceneAsync("UI",LoadSceneMode.Additive));
    }
}
