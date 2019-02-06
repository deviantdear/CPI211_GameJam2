using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed = 25f;
    private float counter;
    public float lifespan = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward.x * speed, transform.forward.y * speed, transform.forward.z * speed);
        transform.Translate(transform.forward * speed * Time.deltaTime);

        if (counter >= lifespan)
        {
            Destroy(gameObject);
        }
    }
}
