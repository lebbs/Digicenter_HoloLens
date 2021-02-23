using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public float sec = 3f;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            Debug.Log("Maalin trigger toimii");
            //GetComponent<ParticleSystem>().Play();
            gameObject.SetActive(false);
        }
    }

    


}
