using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_projectile : MonoBehaviour 
{
	public GameObject shot;
	public float shotTime = 0.5f;

	private bool canShoot = true;
	private float lastInput;
	private float shotStartTime;
	

	// Use this for initialization

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		//if fire1 ... then make object and shoot it
		if((Input.GetAxis("Fire1") > 0) && canShoot)
		{
			canShoot = false;
			shotStartTime = Time.time;
			GameObject obj = GameObject.Instantiate(shot, transform.position, Quaternion.identity);
			obj.GetComponent<move_shot>().direction = this.transform.forward;
		}

		//do logic for the timer
		if( (Time.time - shotStartTime) >= shotTime )
		{
			if(Input.GetAxis("Fire1") != lastInput)
			{
				canShoot = true;
			}
		}

		lastInput = Input.GetAxis("Fire1");
	}
}
