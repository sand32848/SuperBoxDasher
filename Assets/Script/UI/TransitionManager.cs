using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public static TransitionManager instance;
    [SerializeField] private RectTransform Panel;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

    }
    void OnEnable()
    {
        SceneLoader.transition += transScene;
    }

    void OnDisable()
	{
        SceneLoader.transition -= transScene;
    }

    public void transScene(string sceneName)
	{
        Sequence sequence = DOTween.Sequence();

        sequence.SetUpdate(UpdateType.Normal,true);

        sequence.Append(Panel.DOAnchorPosX(0, 0.4f).OnComplete(() => SceneManager.LoadScene(sceneName)));
        sequence.Append(Panel.DOAnchorPosX(0, 0.1f));
        sequence.Append(Panel.DOAnchorPosX(800, 0.4f));
        sequence.Append(Panel.DOAnchorPosX(-800, 0f));

        //Panel.DOAnchorPosX(0, 3f).OnComplete(() => 
        //{
        //    Panel.DOAnchorPosX(422, 3f).OnComplete(() =>
        //  { Panel.DOAnchorPosX(-422, 0f); });
        //}); 

    }
}
