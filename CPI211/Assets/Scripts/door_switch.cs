using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_switch : MonoBehaviour
 {
	public GameObject door;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("collided");
		if(other.tag == "Player")
		{
			door.GetComponent<door_control>().ToggleDoor();
		}
	}
}
