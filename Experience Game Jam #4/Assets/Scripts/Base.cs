using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour {
    public int leben;

    // Use this for initialization
    void Start () {
        leben = 5;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
            leben -= 1;
        }
    }
}
