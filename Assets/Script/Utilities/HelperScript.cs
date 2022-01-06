using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public static class HelperScript
{
	public static IEnumerator Shake(this Transform transform, float Duration = 0, float Power = 0)
	{
		Vector3 originalPos = transform.localPosition;

		float elapsed = 0.0f;

		DOTween.Kill(transform,true);

		while (elapsed < Duration)
		{
			float x = Random.Range(-1f, 1f) * Power;
			float y = Random.Range(-1f, 1f) * Power;

			transform.DOMove(new Vector3(x, y, originalPos.z), 0.1f).OnComplete(() => {
				transform.DOMove(originalPos, 0.1f);
				}); 

		elapsed += Time.deltaTime;

		yield return null;
		}

		transform.localPosition = originalPos;
	}
}
