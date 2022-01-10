using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class EditorSceneLoader : MonoBehaviour
{

}

#if UNITY_EDITOR
[InitializeOnLoad]
class MyClass
{
    static MyClass()
    {
        EditorApplication.update += Update;
    }

    static void Update()
    {
        if (!EditorApplication.isPlaying)
		{
          //  EditorSceneManager.OpenScene("Assets/Scenes/GameplayUI.unity", OpenSceneMode.Additive);
        //    EditorSceneManager.OpenScene("Assets/Scenes/CameraPostProcess.unity", OpenSceneMode.Additive);
        }

    }
    [MenuItem("MyMenu/Do Something %g")]
    static void loadTestScene()
	{
        EditorSceneManager.OpenScene("Assets/Scenes/GameplayUI.unity", OpenSceneMode.Additive);
    }
#endif
}