using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTargetScript : MonoBehaviour
{

	public Transform Target;

	public float Speed = 10f;

	public Vector3 Offset;

	public GameObject[] Targets;

	private void Start()
	{
		Target = Targets[0].transform;

		Debug.Log(transform.position + "|" + Target.GetComponent<RectTransform>().position);
	}

	public void SetTarget(GameObject I)
	{
		if (I.GetComponent<RectTransform>())
		{
			Target = I.GetComponent<RectTransform>();
			transform.position = new Vector3(transform.position.x - Target.transform.position.x * .67f, transform.position.y, transform.position.z);

			Debug.Log(transform.position + "|" + Target.GetComponent<RectTransform>().position);
		}
		else
		{
			Debug.Log("No Rect transform, this won't do");
		}
	}
}
