using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    [SerializeField]GameObject player;
	[SerializeField] GameObject particle;
	[SerializeField] GameObject backgroundParticle;
	[SerializeField] GameObject greenCircle;
	[SerializeField] GameObject congratText1;
	[SerializeField] GameObject congratText2;
	[SerializeField] GameObject congratUI;
	[SerializeField] RectTransform mainMenuButton;
	[SerializeField] Image panel;
	
	GameObject camera;
	private bool isAiming = false;
	private bool firstTime = false;
	private InputController inputController;

	// Start is called before the first frame update
	void Start()
    {
		inputController = GetComponent<InputController>();
		camera = GameObject.FindWithTag("MainCamera");
		AudioManager.instance.LerpMute("MainTheme");
	}

    // Update is called once per frame
    void Update()
    {
		//Vector3(-13.3999996,-3,0)
		//Vector3(2.05999994, 0.5, 0)
		if (firstTime)
		{
			return;
		}

		if (inputController.LeftClick)
		{
			if (AudioManager.instance != null)
			{
				AudioManager.instance.Play("ChargeUp");
			}
		}

		if (inputController.LeftHold )
		{
			isAiming = true;
		}

		if (!inputController.LeftHold && isAiming)
		{
			if (AudioManager.instance != null)
			{
				AudioManager.instance.Play("DashEcho");
			}

			Sequence sequence = DOTween.Sequence();
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0.05f).From(new Vector3(-13.39f,-3,0)).SetEase(Ease.OutExpo).OnComplete(()=> {Instantiate(particle,new Vector3(0,0,0),Quaternion.identity); }));
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0f).OnComplete(() => { Destroy(greenCircle); }));
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0f).OnComplete(() => { camera.transform.DOShakePosition(1,0.3f,10,90,false,false); }));
			sequence.Append(panel.DOColor(new Color32(255, 255, 255, 255), 0f).OnComplete(() => { panel.DOColor(new Color32(0,0,0,0),1f); }));
			sequence.Append(player.transform.DOMove(new Vector3(3.3f, 0.7f, 0), 2f).SetEase(Ease.OutExpo));

			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0.5f).SetEase(Ease.Linear).OnComplete(() => {congratUI.SetActive(true); }));
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0f).OnComplete(() => { AudioManager.instance?.Play("MainTheme",0.15f); }));
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0f).OnComplete(() => { backgroundParticle.SetActive(true); }));
			sequence.Append(player.transform.DOMove(new Vector3(2.05999994f, 0.5f, 0), 0f).OnComplete(() => { player.transform.DOMove(new Vector3(-1.44000006f, -0.03f, 0), 1f).SetLoops(-1,LoopType.Yoyo); }));

			sequence.Insert(2,congratText1.GetComponent<RectTransform>().DOAnchorPos(new Vector3(-24, 169, 0), 2f).SetEase(Ease.OutQuad));
			sequence.Insert(2,congratText2.GetComponent<RectTransform>().DOAnchorPos(new Vector3(-13, -176, 0), 2f).SetEase(Ease.OutQuad));
			sequence.Insert(2, mainMenuButton.GetComponent<RectTransform>().DOAnchorPos(new Vector3(251, -255, 0), 2f).SetEase(Ease.OutQuad));

			isAiming = false;

			firstTime = true;
		}
	}
}
