using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
				if (i != (TargetScript.Targets.Length - 1))
				{
					TargetScript.SetTarget(TargetScript.Targets[i + 1].gameObject);
					break;
				}
				else
				{
					break;
				}
			}
		}
	}


	public void MoveLeft()
	{
		for (int i = 0; i < TargetScript.Targets.Length; i++)
		{
			if (TargetScript.Target.gameObject == TargetScript.Targets[i])
			{
				if (i != (TargetScript.Targets.Length - TargetScript.Targets.Length))
				{
					TargetScript.SetTarget(TargetScript.Targets[i - 1].gameObject);
					break;
				}
				else
				{
					break;
				}
			}
		}
	}


	public void ReturnToMenu()
	{
		SceneManager.LoadSceneAsync("Menu");
	}
}
