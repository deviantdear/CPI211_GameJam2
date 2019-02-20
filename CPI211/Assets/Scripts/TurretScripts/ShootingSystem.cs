using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public float fireRate;
    public float fieldOfview;
    public bool beam;
    public int damage;
    public List<GameObject> projectileSpawns;
    public GameObject projectile;
    public GameObject target;
    List<GameObject> m_lastProjectile = new List<GameObject>();
    float m_fireTimer = 0.0f;

    void Update()
    {
        if(beam && m_lastProjectile.Count <= 0){
            float angle = getAngle();

            if (angle < fieldOfview)
                SpawnProjectiles();
        }
        else if(beam && m_lastProjectile.Count > 0)
        {
            float angle = getAngle();

            if(angle > fieldOfview)
            {
                while(m_lastProjectile.Count > 0)
                {
                    Destroy(m_lastProjectile[0]);
                    m_lastProjectile.RemoveAt(0);
                }
            }
        }
        else
        {
            m_fireTimer += Time.deltaTime;
            if(m_fireTimer >= fireRate)
            {
                float angle = getAngle();
                if (angle < fieldOfview)
                {
                    SpawnProjectiles();
                    m_fireTimer = 0.0f;
                }
                
            }
        }
    }

    void SpawnProjectiles()
    {
        if (!projectile)
        {
            return;
        }

        //Clears last projectiles spawned
        m_lastProjectile.Clear();

        for(int i = 0; i < projectileSpawns.Count; i++)
        {
            if (projectileSpawns[i])
            {
                GameObject proj = Instantiate(projectile, projectileSpawns[i].transform.position, Quaternion.Euler(projectileSpawns[i].transform.forward)) as GameObject;
                proj.GetComponent<BaseProjectile>().FireProjectile(projectileSpawns[i],target, damage);
            }
        }
    }

    float getAngle()
    {
        float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(target.transform.position - transform.position));

        return angle;
    }
}
