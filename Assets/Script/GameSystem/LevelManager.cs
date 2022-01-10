using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    List<AsyncOperation> sceneToLoad = new List<AsyncOperation>();
    // Start is called before the first frame update

    private void Awake()
    { 

        if (!SceneManager.GetSceneByName("GameplayUI").isLoaded)
        {
            sceneToLoad.Add(SceneManager.LoadSceneAsync("GameplayUI", LoadSceneMode.Additive));
        }



    }

    
}
