using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SlowMotion : MonoBehaviour
{
    private float slowMotion = 0.1f;
    private float normalTime = 1.0f;
    private bool inSlowMo = false;

    [SerializeField] private PlayerController player;

    void Update()
    {
        //Check to see if the character is moving, if they are run at normal time. If not, run in slow motion
       if(player.characterController.velocity.magnitude > 0)
        {
            if (inSlowMo)
            {
                //Sets normal time to switch to slow motion time
                Time.timeScale = normalTime;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                Debug.Log(Time.timeScale.ToString("0"));
                inSlowMo = false;
            }
        }
        else
        {
            if (!inSlowMo)
            {
                Time.timeScale = slowMotion;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
                Debug.Log(Time.timeScale.ToString("0"));
                inSlowMo = true;
            }
        }
    }
}
