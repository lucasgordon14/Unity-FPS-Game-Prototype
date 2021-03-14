using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(10 * Time.deltaTime, 50 * Time.deltaTime, 0); //rotates 50 degrees per second around y axis, rotates 10 degrees per second around x axis
    }
}
