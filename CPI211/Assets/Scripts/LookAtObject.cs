using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 relativePos = target.position-transform.position;
		transform.rotation = Quaternion.LookRotation(relativePos);
		
	}
}
