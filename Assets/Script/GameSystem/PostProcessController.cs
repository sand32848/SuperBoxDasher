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
	[SerializeField] float lensVar;
	[SerializeField] float bloomVarDefault;
	[SerializeField] float chromaVarDefault;
	[SerializeField] float lensVarDefault;
	[SerializeField] private bool testing = false;


    private void OnEnable()
	{
        Ball.GreenBallHit += PostHit;
		Red.redHitPre += PostHitKill;
	}

	private void OnDisable()
	{
        Ball.GreenBallHit -= PostHit;
		Red.redHitPre -= PostHitKill;
	}
	private void Start()
	{
		postProcess.profile.TryGetSettings(out colorGrading);
		postProcess.profile.TryGetSettings(out lensDistortion);
		postProcess.profile.TryGetSettings(out bloom);
		postProcess.profile.TryGetSettings(out chromaticAberration);

		bloom.intensity.value = bloomVarDefault;
		chromaticAberration.intensity.value = chromaVarDefault;
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
		DOTween.Kill("Effect",true);

		DOTween.To(() => bloom.intensity.value, x => bloom.intensity.value = x, bloomVar, 0.1f).SetId("Effect").OnComplete(() => 
		{ DOTween.To(() => bloom.intensity.value, x => bloom.intensity.value = x, bloomVarDefault, 1).SetId("Effect"); });

		DOTween.To(() => chromaticAberration.intensity.value, x => chromaticAberration.intensity.value = x, chromaVar, 0.1f).SetId("Effect").OnComplete(() =>
		{ DOTween.To(() => chromaticAberration.intensity.value, x => chromaticAberration.intensity.value = x, chromaVarDefault, 0.2f).SetId("Effect"); });

		DOTween.To(() => lensDistortion.intensity.value, x => lensDistortion.intensity.value = x, lensVar, 0.1f).SetId("Effect").OnComplete(() =>
		{ DOTween.To(() => lensDistortion.intensity.value, x => lensDistortion.intensity.value = x, lensVarDefault, 0.2f).SetId("Effect"); });
	}

	public void PostHitKill()
	{
		bloom.color.value = new Color32(255,76,81,1);

		PostHit();
	}
}
