using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class SlowMotion : MonoBehaviour
{
    private float slowMotion = 0.1f;
    private float normalTime = 1.0f;
    private bool inSlowMo = false;
    private float i = 0;

    [SerializeField] private FirstPersonController player;

    void Update()
    {
        //Check to see if the character is moving, if they are run at normal time. If not, run in slow motion
       if(player.m_CharacterController.velocity.magnitude > 0)
        {
            if (inSlowMo)
            {
                //Sets normal time to switch to slow motion time
                //i = player.m_CharacterController.velocity.magnitude / player.m_WalkSpeed;
                Time.timeScale = normalTime;
                //Time.fixedDeltaTime = Mathf.Lerp(normalTime, slowMotion, i);
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
                //i = player.m_CharacterController.velocity.magnitude / player.m_WalkSpeed;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
               // Time.fixedDeltaTime = Mathf.Lerp(slowMotion, normalTime, i);
                Debug.Log(Time.timeScale.ToString("0"));
                inSlowMo = true;
            }
        }
    }
}
