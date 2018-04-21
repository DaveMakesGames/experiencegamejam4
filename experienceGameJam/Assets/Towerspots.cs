using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerspots : MonoBehaviour
{

    // Use this for initialization

    public void OnMouseDown()
    {
        Instantiate(Resources.Load<GameObject>("PopUpCanvas"), transform.position, transform.rotation);
    }

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
