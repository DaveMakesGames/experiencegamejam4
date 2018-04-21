using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour {

    public GameManager gameManager;

    public Image WinScreen;
    public Image LoseScreen;

    // Use this for initialization
    void Start () {
        WinScreen.enabled = false;

        for (int i = 0; i < WinScreen.transform.childCount; i++)
        {
            var child = WinScreen.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (gameManager.getLifePoints() < 1) {
            WinScreen.enabled = true;

            for (int i = 0; i < WinScreen.transform.childCount; i++)
            {
                var child = WinScreen.transform.GetChild(i).gameObject;
                if (child != null)
                    child.SetActive(true);
            }
        }

    }
}
