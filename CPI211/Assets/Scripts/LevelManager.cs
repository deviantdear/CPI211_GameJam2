using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public Transform player;
    public int numLevels = 5;
    public int currentLevel = 0;
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> gameLevels = new List<GameObject>();
    public Text gameUI;
    
    // Start is called before the first frame update
    void Start()
    { 
        populateLevel(currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void populateLevel(int level)
    {
        if (level < numLevels)
        {
            gameLevels[level].SetActive(true);
            player = spawnPoints[level].GetComponent<Transform>();
            //update game UI
        }
        else
        {
            gameUI.text = "You've reached the end of The Game";
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            currentLevel++;
            populateLevel(currentLevel);
        }
    }
}
