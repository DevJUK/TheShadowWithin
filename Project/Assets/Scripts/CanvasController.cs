using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
	public RectTransform Menu;
	public RectTransform RedLevels;

	public Vector3 LastPos;
	public Vector3 CurrentPos;


	private void Start()
	{
		CurrentPos = Menu.transform.position;
	}


	private void Update()
	{
		ChangeContent();
	}


	public void ChangeContent()
	{
		
	}
}
