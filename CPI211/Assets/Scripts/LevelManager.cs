using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform player;
    public int numLevels = 5;
    public int currentLevel;
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> gameLevels = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void populateLevel(int level)
    {

    }
}
