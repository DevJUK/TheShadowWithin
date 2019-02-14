using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetScript : MonoBehaviour
{

	public RectTransform Target;

	public float Speed = 0.125f;

	public Vector3 Offset;
	public Vector3 SpeedVec;

	public GameObject[] Targets;

	private void Start()
	{
		SpeedVec = new Vector3(0, 0, Speed);
		SetTarget(Targets[0]);
	}

	private void LateUpdate()
	{
		Vector3 Ideal = Target.position + Offset;
		Vector3 Smooth = Vector3.SmoothDamp(transform.position, Ideal, ref SpeedVec, Time.deltaTime);
		Camera.main.transform.position = Smooth;
	}


	public void SetTarget(GameObject I)
	{
		if (I.GetComponent<RectTransform>())
		{
			Target = I.GetComponent<RectTransform>();
		}
		else
		{
			Debug.Log("No Rect transform, this won't do");
		}
	}
}
