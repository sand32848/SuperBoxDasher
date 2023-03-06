using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(EventTrigger))]
public class ButtonAnimation : MonoBehaviour
{
	EventTrigger eventTrigger;
	Button button;

	private void Start()
	{
		button = GetComponent<Button>();
		eventTrigger = GetComponent<EventTrigger>();

		EventTrigger.Entry pointerEnter = new EventTrigger.Entry();
		pointerEnter.eventID = EventTriggerType.PointerDown;
		pointerEnter.callback.AddListener((data) => { OnPointerDownDelegate((PointerEventData)data); });
		eventTrigger.triggers.Add(pointerEnter);

		EventTrigger.Entry pointerClick = new EventTrigger.Entry();
		pointerClick.eventID = EventTriggerType.PointerClick;
		pointerClick.callback.AddListener((data) => { OnPointerClickDelegate((PointerEventData)data); });
		eventTrigger.triggers.Add(pointerClick);
	}
	public void ButtonHover()
	{
		transform.DOScale(1.3f, 0.3f).SetEase(Ease.OutBack).SetUpdate(true);
	}

	public void ButtonExit()
	{

			transform.DOScale(1, 0.3f).SetUpdate(true);
	}

	public void OnPointerClickDelegate(PointerEventData data)
	{
		if (button.interactable == false)
		{
			return;
		}
		AudioManager.instance?.Play("ButtonClick");
	}

	public void OnPointerDownDelegate(PointerEventData data)
	{
		transform.DOShakePosition(1, 5f, 10, 90, false, true);
		transform.DOScale(1.1f, 0.3f).SetUpdate(true);
	}
}
