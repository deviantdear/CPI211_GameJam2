using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZoneManager : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI gameUI;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Zone1")
        {
            gameUI.SetText("Zone 1");
        }
        else if(other.gameObject.tag == "Zone2")
        {
            gameUI.SetText("Zone 2");
        }
        else if (other.gameObject.tag == "Zone3")
        {
            gameUI.SetText("Zone 3");
        }
        else if (other.gameObject.tag == "Zone4")
        {
            gameUI.SetText("Zone 4");
        }
        else
        {
            gameUI.SetText("No Zone");
        }
    }

}
