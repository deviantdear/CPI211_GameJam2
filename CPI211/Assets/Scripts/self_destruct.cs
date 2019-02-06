using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class self_destruct : MonoBehaviour 
{
	//the goal of this component is destroy the object it's attached to after a certain time
	public float duration = 0.0f;

	private float startTime;


	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if((Time.time - startTime) >= duration)
		{
			Destroy(gameObject);
		}
	}
}
