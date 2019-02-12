using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public int numLevels = 4;
    public int currentLevel;
    public List<GameObject> gameLevels = new List<GameObject>();
    public TextMeshProUGUI gameUI;

    #region Singleton

    public static LevelManager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

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
        if (level < numLevels && level >= 0)
        {
            gameLevels[level].SetActive(true);
            
            //update game UI
        }
        else
        {
             gameUI.SetText("You've reached the end of The Game");
        }

    }

   
}
