﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOriginalPosition : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 originalPosition;
    Quaternion startRotation;
    Rigidbody rigidbody;

    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, transform.position.z);
        startRotation = transform.rotation;
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
        rigidbody.velocity = new Vector3(0, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")||
            collision.gameObject.CompareTag("Target1")||
            collision.gameObject.CompareTag("Target2"))
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
            gameObject.transform.rotation = startRotation;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.y <= -10)
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
            gameObject.transform.rotation = startRotation;
        }

    }
}
