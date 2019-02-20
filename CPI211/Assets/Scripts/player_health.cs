using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : health_manager
{
    public GameObject gameUI;

    public override void Die()
    {
        gameUI.SetActive(true);
    }

}
