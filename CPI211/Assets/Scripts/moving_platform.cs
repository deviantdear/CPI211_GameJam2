using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_platform : MonoBehaviour 
{
	public Transform start;
	public Transform end;

	public float tripDuration = 3.0f;
	private float startTime;
	private bool goForward = true;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;
		transform.position = start.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float percent;
		if(goForward)
		{
			percent = (Time.time - startTime)/tripDuration;
		}
		else
		{
			float temp = (Time.time - startTime)/tripDuration;
			percent = 1.0f - temp;
		}

		transform.position = Vector3.Lerp(start.position, end.position, percent);

		if(percent >= 1.0f || percent <= 0f)
		{
			startTime = Time.time;
			goForward = goForward ^ true;
		}
	}
}
