using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ButtonImageLoader : MonoBehaviour
{
	[SerializeField] private LevelSelectManager levelSelectManager;
	EventTrigger eventTrigger;
	Button button;

	private void Start()
	{
		button = GetComponent<Button>();
		eventTrigger = GetComponent<EventTrigger>();

		EventTrigger.Entry pointerEnter = new EventTrigger.Entry();
		pointerEnter.eventID = EventTriggerType.PointerEnter;
		pointerEnter.callback.AddListener((data) => { OnPointerEnter((PointerEventData)data); });
		eventTrigger.triggers.Add(pointerEnter);
	}

	public void OnPointerEnter(PointerEventData data)
	{
		if (button.interactable == false)
		{
			return;
		}

		levelSelectManager.changePreviewImage(transform.GetSiblingIndex());
	}

}
