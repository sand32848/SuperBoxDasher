using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject lostUI;
    [SerializeField] private GameObject winUI;
	// Start is called before the first frame update

	private void OnEnable()
	{
		TimeManager.killPlayer += callLoseScreen;
		GameManager.callWinScreen += callWinScreen;
	}

	private void OnDisable()
	{
		TimeManager.killPlayer -= callLoseScreen;
		GameManager.callWinScreen -= callWinScreen;
	}

    public void callLoseScreen()
	{
        lostUI.SetActive(true);
	}

	public void callWinScreen()
	{
		winUI.SetActive(true);
	}
}