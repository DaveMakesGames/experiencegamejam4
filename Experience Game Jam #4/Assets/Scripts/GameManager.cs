using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public EnemyBase enemyBase;
    public Base Base;
    public GameObject loseScreen;
    public GameObject winScreen;

    // Use this for initialization
    void Start () {
        loseScreen.SetActive(false);
        winScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Base.leben < 1) {
            loseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        if (enemyBase.enemyCount < 1) {
            winScreen.SetActive(true);
            Time.timeScale = 0;
        }
	}   
}
