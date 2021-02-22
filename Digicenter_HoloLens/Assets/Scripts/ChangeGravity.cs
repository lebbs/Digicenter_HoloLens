using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    public float gravity;


    public void Start()
    {
        Physics.gravity = new Vector3(0, gravity, 0);
    }


}
