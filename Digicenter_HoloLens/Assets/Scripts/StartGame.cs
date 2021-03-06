using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject spawner;
    public int health = 100;
    public GameObject fracturedObject;
    public GameObject text;

    public void OnDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameStart();
            Destroy();
        }
    }

    private void GameStart()
    {
        spawner.SetActive(true);
        text.SetActive(false);
    }
    public void Destroy()
    {
        Instantiate(fracturedObject, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
