﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public List<Transform> waypointList;
    public float speed = 100;
    float rotateSpeed = 8;
    int currentWaypoint = 0;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0, 50, 0);
    }

    void Update()
    {
        RotateEnemy(waypointList[currentWaypoint].position);
        MoveToPoints();
    }




    private void MoveToPoints()
    {

        Vector3 targetPosition = waypointList[currentWaypoint].position;
        Vector3 blub = new Vector3(targetPosition.x, 0, targetPosition.z);
        Vector3 Geschwindigkeit;
        Vector3 Bewegungsrichtung = transform.TransformDirection(Vector3.forward);

        Vector3 Abstand = blub - transform.position;

        Geschwindigkeit = Bewegungsrichtung.normalized * speed * Time.deltaTime;

        if (Abstand.magnitude > 1)
        {
            //animation.Play("walk");
        }
        else
        {
            if (currentWaypoint < waypointList.Count - 1)
            {
                currentWaypoint++;
            }
            else
            {
                currentWaypoint = 0;
            }
            Geschwindigkeit = Vector3.zero;
        }
        rb.velocity = Geschwindigkeit;
    }

    private void RotateEnemy(Vector3 Destination)
    {
        Quaternion destRotation;
        Vector3 relativePos;
        relativePos = Destination - transform.position;
        relativePos = new Vector3(relativePos.x, transform.position.y, relativePos.z);
        destRotation = Quaternion.LookRotation(relativePos);
        transform.rotation = Quaternion.Slerp(transform.rotation, destRotation, rotateSpeed * Time.deltaTime);
    }
}
