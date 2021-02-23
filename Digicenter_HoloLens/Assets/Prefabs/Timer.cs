using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public GameObject x1;
    public GameObject x2;
    public GameObject x3;

    public float sec = 3f;


    private void Update()
    {
        if (!x1.activeSelf)
        {

            StartCoroutine(ShowAndHide(x1, 3.0f));
        }

        if (!x2.activeSelf)
        {

            StartCoroutine(ShowAndHide(x2, 3.0f));
        }

        if (!x3.activeSelf)
        {
           
            StartCoroutine(ShowAndHide(x3, 3.0f));
        }
    }
    private IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(true);
        
    }
}
