using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_boss_health : health_manager
{
    public LevelManager lvlManager;

    public override void Die()
    {
        Destroy(gameObject);
        lvlManager.nextLevel();
    }
    
  
}
