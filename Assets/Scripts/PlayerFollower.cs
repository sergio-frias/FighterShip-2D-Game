using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    //public Transform target;
    public Vector3 follow;

    void Update()
    {

        Vector3 position = transform.position;
        position.y += .01f;
        transform.position = position;
        
    }
}