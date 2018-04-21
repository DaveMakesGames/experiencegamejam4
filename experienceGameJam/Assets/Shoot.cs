using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform bullet_spawn; //spot on the enemy where the bullets will be instantiatet
    float delay = 0.3f; //delay between shots
    float wait_time = 2; // wait time before shooting again

    void OnTriggerEnter2D(Collider col)
    {
        if (col.gameObject.name == "enemy") 
        {
            InvokeRepeating("Shoot", delay, wait_time); //start shooting and keep on repeating it as long as needed
        }
    }

    public void ShootIt() 
    {
        Instantiate(Resources.Load<GameObject>("TowerBullet"), bullet_spawn.position, bullet_spawn.rotation);
    }
}
