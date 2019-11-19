using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public float maxSpeed = 7;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        Vector3 posChange = new Vector3(0, maxSpeed * Time.deltaTime, 0);

        pos += transform.rotation * posChange;

        transform.position = pos;
    }
}
