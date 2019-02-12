using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
	protected ScrollRect scrollRect;
	protected RectTransform contentPanel;

	public Vector3 LastPos;
	public Vector3 CurrentPos;

	public Image[] Content; 


	private void Start()
	{
		scrollRect = GetComponent<ScrollRect>();
		contentPanel = GetComponent<RectTransform>();
		CurrentPos = transform.position;
	}


	private void Update()
	{
		ChangeContent();

	}


	public void ChangeContent()
	{
		if (transform.position.x > CurrentPos.x + 100)
		{
			Debug.Log("test");
			//GetComponent<ScrollRect>().content = Content[1].rectTransform;

		}

		if (transform.position.x < CurrentPos.x - 100)
		{
			Debug.Log("Test2");
			//GetComponent<ScrollRect>().content = Content[1].rectTransform;
		}
	}
}
