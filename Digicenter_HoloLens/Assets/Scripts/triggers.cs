using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour
{
    public GameObject txt;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pallo"))
        {
            txt.SetActive(true);
            Debug.Log("Jeejee triggeri toimii");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        txt.SetActive(false);
    }
}
