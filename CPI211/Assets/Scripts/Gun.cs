using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform ammo;
    private float counter;
    public float fireDelay = 0.25f;
    public bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter = Time.deltaTime;
        if (Input.GetAxis("Fire1") > 0)
        {
            //returns the thing we made 
            Transform bullet = Instantiate(ammo, transform.position, Quaternion.identity);
            bullet.forward = this.transform.forward;
            canShoot = false;
            counter = 0f;
        }

        if (counter >= fireDelay)
        {
            canShoot = true;
        }
    }
}
