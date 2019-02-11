using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agent;
    public GameObject shot;
    public float shotTime = 1f;

    private bool canShoot = true;
    private float lastInput;
    private float shotStartTime;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if(distance <= lookRadius)
        {
            //agent.SetDestination(target.position);

            if(distance <= agent.stoppingDistance)
            {
                //Attack target
                //Face target
                FaceTarget();
                ShootTarget();
            }
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime*5f);
    }

    void ShootTarget()
    {
        if (canShoot)
        {
            canShoot = false;
            shotStartTime = Time.time;
            GameObject obj = GameObject.Instantiate(shot, transform.position, Quaternion.identity);
            obj.GetComponent<move_shot>().direction = this.transform.forward;
        }

        //do logic for the timer
        if ((Time.time - shotStartTime) >= shotTime)
        {
                canShoot = true;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
