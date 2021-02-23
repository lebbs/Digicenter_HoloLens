using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHit : MonoBehaviour
{

    public GameObject targetCollider;

    public GameObject spawnObjectOnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        targetCollider = GameObject.FindWithTag("Target");

        if (collision.gameObject.CompareTag("Target"))
        {
            GameObject spawned = GameObject.Instantiate(spawnObjectOnCollision);

        }
    }

}
