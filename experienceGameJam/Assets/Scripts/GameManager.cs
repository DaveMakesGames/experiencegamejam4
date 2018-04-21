using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int enemyCount;
    public int money;
    public int livepoints;

    // Use this for initialization
    void Start () {
        money = 5;
        enemyCount = 20;
        livepoints = 6;
    }
	
	// Update is called once per frame
	void Update () {
        if (livepoints < 1) {
            
            Time.timeScale = 0;
        }
        if (enemyCount < 1) {
            
            Time.timeScale = 0;
        }
	}

    public int getLifePoints() {
        return livepoints;
    }

    public int getTime()
    {
        return Mathf.RoundToInt(Time.timeSinceLevelLoad);
    }

    public int getMoney()
    {
        return money;
    }
}
