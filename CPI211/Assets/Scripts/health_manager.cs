using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_manager : MonoBehaviour {

	public int health = 10;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//death logic
		if(health <= 0)
		{
            Die();
		}
	}

	public void doDamage(int damage)
	{
		this.health -= damage;
	}

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
