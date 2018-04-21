using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towerbase : MonoBehaviour
{
    public GameObject shootingRange;
    public float aoeDamage = 25;
    public float enemyLife;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            AttackEnemy();
        }
    }

    public void Attack()
    {

    }

    public void AttackEnemy()
    {

        if (shootingRange == null)
        {

            return;
        }

        int layer = 1 << 8;
        float radius = shootingRange.GetComponent<SphereCollider>().radius * 6;
        Collider[] beatTargets = Physics.OverlapSphere(transform.position, radius, layer);
        //Debug.Log("return");
        if (beatTargets == null)
        {
            return;
        }

        var collisionsCount = beatTargets.Length;
        for (var i = 0; i < collisionsCount; ++i)
        {
            //Debug.Log("damage");
            var target = beatTargets[i].GetComponent<EnemyStats>();
            if (target == null/* || !target.IsAlive*/)
            {
                continue;
            }

            target.life -= aoeDamage;
            //AOEAttack(target);
        }
    }

 //   // Use this for initialization
 //   void Start ()
 //   {
		
	//}
	
	//// Update is called once per frame
	//void Update ()
 //   {
		
	//}
}
