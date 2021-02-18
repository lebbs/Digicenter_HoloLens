using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetectionGreen : MonoBehaviour
{
    public SpawnCubes spawn;
    //public GameObject right;
    //public GameObject wrong;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GreenSphere"))
        {
            Debug.Log("vihreä kuutio toimii.");
      //      right.SetActive(true);
            other.gameObject.SetActive(false);
            spawn.SpawnObject();
        //    StartCoroutine(ShowAndHide(right, 3.0f));
        }
        else
        {
            Debug.Log("Väärän värinen kuutio laitettu");
          //  wrong.SetActive(true);
        }
    }

    private IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
       // right.SetActive(false);
      // wrong.SetActive(false);
    }
}
