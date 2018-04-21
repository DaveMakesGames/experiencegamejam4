using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float life = 50;
    public float damage = 20;
    public float damgeOnPlayer = 2;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(life <= 0)
        {
            Destroy(gameObject);
        }
	}
}
