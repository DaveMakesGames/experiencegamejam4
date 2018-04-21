using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerbase : MonoBehaviour
{
    public GameObject shootingRange;
    public GameObject enemy;
    public float aoeDamage = 25;
    public float enemyLife;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Attack();
        }
    }

    public void Attack()
    {

    }

    public virtual void FindRandomTarget()
    {
        if (shootingRange == null)
        {
            return;
        }

        int layer = 1 << 8;
        float radius = shootingRange.GetComponent<SphereCollider>().radius * 2;
        Collider[] stumpTargets = Physics.OverlapSphere(transform.position, radius, layer);
        if (stumpTargets == null)
        {
            return;
        }

        var collisionsCount = stumpTargets.Length;
        for (var i = 0; i < collisionsCount; ++i)
        {
            var target = stumpTargets[i].GetComponent<EnemyStats>();
            if (target == null/* || !target.IsAlive*/)
            {
                continue;
            }

            target.life -= aoeDamage;
            //StompAttack(target);
        }
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
