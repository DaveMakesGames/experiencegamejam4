using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerbase : MonoBehaviour
{
    public GameObject towerRange;
    public GameObject enemy;
    public float enemyLife;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {

        }
    }

    public void AOE_Damage()
    {

    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
