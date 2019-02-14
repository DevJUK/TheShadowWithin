using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuArrowScript : MonoBehaviour
{

	private CameraTargetScript TargetScript;

	private void Start()
	{
		TargetScript = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraTargetScript>();
	}

	public void MoveRight()
	{
		for (int i = 0; i < TargetScript.Targets.Length; i++)
		{
			if (TargetScript.Target.gameObject == TargetScript.Targets[i])
			{
				TargetScript.SetTarget(TargetScript.Targets[i + 1].gameObject);
				break;
			}
		}
	}

}
