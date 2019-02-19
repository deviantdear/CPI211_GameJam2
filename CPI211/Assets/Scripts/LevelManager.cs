using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelManager : MonoBehaviour
{
    public GameObject player;
    private int numLevels = 5;
    public int currentLevel = 0;
    public List<GameObject> gameLevels = new List<GameObject>();
    public List<GameObject> playerPosition = new List<GameObject>();
    public TextMeshProUGUI gameUI;
    public GameObject endGameGUI;
    bool playerAlive = true;


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
        Time.timeScale = 1;
        populateLevel(currentLevel);
        setPlayerPosition(playerPosition[currentLevel]);
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

    private void setPlayerPosition(GameObject placement)
    {
        Vector3 position = placement.transform.position;
        Quaternion rotation = placement.transform.rotation;
        Vector3 localScale = placement.transform.localScale;

        player.transform.position = position;
        player.SetActive(true);
    }

    public void nextLevel()
    {
        gameLevels[currentLevel].SetActive(false);
        player.SetActive(false);
        currentLevel++;
        if(currentLevel >= 5)
        {
            endGameGUI.SetActive(true);
            Time.timeScale = 0;
        }
        else
        { 
            populateLevel(currentLevel);
            setPlayerPosition(playerPosition[currentLevel]);
            gameUI.SetText("Level #" +(currentLevel+1));
        }
    }

}
