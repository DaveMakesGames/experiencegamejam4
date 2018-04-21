using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float speed = 9; //speed of the bullets
    GameObject enemy; // the targets
    float lifetime = 3; // time after bullets will be destroyed if they dont hit a target

    void Start()
    {
        enemy = GameObject.Find("enemy");
    }


    void Update()
    {
        GetComponent<Rigidbody>().velocity = (enemy.transform.position - transform.position).normalized * speed;
        
        Destroy(gameObject, 3); 
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy") //when a bullet collides with the target
        {
            Destroy(gameObject); //the bullet will be destroyed
        }
    }
}
