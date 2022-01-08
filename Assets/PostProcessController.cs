using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using DG.Tweening;

[ExecuteInEditMode]
public class PostProcessController : MonoBehaviour
{
    [SerializeField]
    private PostProcessVolume postProcess;
    private ChromaticAberration chromaticAberration;
    private LensDistortion lensDistortion;
    private ColorGrading colorGrading;
    private Bloom bloom;

	[SerializeField] float bloomVar;
	[SerializeField] float chromaVar;


    private void OnEnable()
	{
        Ball.GreenBallHit += PostHit;
	}

	private void OnDisable()
	{
        Ball.GreenBallHit -= PostHit;
    }
	private void Start()
	{
		postProcess.profile.TryGetSettings(out colorGrading);
		postProcess.profile.TryGetSettings(out lensDistortion);
		postProcess.profile.TryGetSettings(out bloom);
		postProcess.profile.TryGetSettings(out chromaticAberration);

		bloom.intensity.value = 0;
		chromaticAberration.intensity.value = 0;
	}

	private void Update()
	{
		if (Application.isEditor && !Application.isPlaying)
		{
			bloom.intensity.value = bloomVar;
			chromaticAberration.intensity.value = chromaVar;

		}
	}


	public void PostHit()
	{
		DOTween.KillAll(true, "Player");

		DOTween.To(() => bloom.intensity.value, x => bloom.intensity.value = x, bloomVar, 0.1f).OnComplete(() => 
		{ DOTween.To(() => bloom.intensity.value, x => bloom.intensity.value = x, 0.15f, 1); });

		DOTween.To(() => chromaticAberration.intensity.value, x => chromaticAberration.intensity.value = x, chromaVar, 0.1f).OnComplete(() =>
		{ DOTween.To(() => chromaticAberration.intensity.value, x => chromaticAberration.intensity.value = x, 0f, 0.2f); });
	}
}
