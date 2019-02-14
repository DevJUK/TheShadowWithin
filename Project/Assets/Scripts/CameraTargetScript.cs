using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetScript : MonoBehaviour
{

	public RectTransform Target;

	public float Speed = 10f;

	public Vector3 Offset;

	public GameObject[] Targets;

	private void Start()
	{
		Target = Targets[0].gameObject.GetComponent<RectTransform>();

		Debug.Log(transform.position + "|" + Target.GetComponent<RectTransform>().position);
	}

	public void SetTarget(GameObject I)
	{
		if (I.GetComponent<RectTransform>())
		{
			Debug.Log(transform.position + "|" + Target.GetComponent<RectTransform>().position + "|");

			Target = I.GetComponent<RectTransform>();

			Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y, -10f), 1f);
		}
		else
		{
			Debug.Log("No Rect transform, this won't do");
		}
	}
}
