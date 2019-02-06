using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_shot : MonoBehaviour
 {
	public Vector3 direction;
	public float speed;
	public int damage;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += direction * speed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider other)
	{
		//Debug.Log(other.gameObject.tag);
		if(other.gameObject.tag == "EnemyAI")
		{
			//Debug.Log("Hit Something!");
			other.GetComponent<health_manager>().doDamage(damage);			
		}
		Destroy(gameObject);
	}	
}
