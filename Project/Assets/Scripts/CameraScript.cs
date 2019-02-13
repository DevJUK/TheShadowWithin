using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

	public GameObject Target;
	private float CameraHeight;
	private float CameraWidth;
	private Vector3 MinCamera;
	private Vector3 MaxCamera;


	private void Start()
	{
		CameraHeight = Camera.main.orthographicSize * 2;
		CameraWidth = Camera.main.aspect * CameraHeight;

		MinCamera = GameObject.Find("Level").GetComponent<CompositeCollider2D>().bounds.min;
		MaxCamera = GameObject.Find("Level").GetComponent<CompositeCollider2D>().bounds.max;

		if (GameObject.Find("Hunter"))
		{
			Target = GameObject.Find("Hunter");

			transform.position = Target.transform.position;
		}
	}

	private void Update()
	{
		if (GameObject.Find("Player"))
		{
			Vector3 NewPos = Target.transform.position;

			transform.position = new Vector3(Mathf.Clamp(NewPos.x, MinCamera.x + CameraWidth / 2, MaxCamera.x - CameraWidth / 2), Mathf.Clamp(NewPos.y, MinCamera.y + CameraHeight / 2, MaxCamera.y - CameraHeight / 2), transform.position.z);
		}
	}
}
