using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public float fireRate;
    public float fieldOfview;
    public bool beam;
    public List<GameObject> projectileSpawns;
    public GameObject projectile;

    List<GameObject> m_lastProjectile = new List<GameObject>();
    float m_fireTimer = 0.0f;

    void Update()
    {
        
    }

    void SpawnProjectiles()
    {
        if (!projectile)
        {
            return;
        }
        for(int i = 0; i < projectileSpawns.Count; i++)
        {
            if (projectileSpawns[i])
            {

            }
        }
    }
}
