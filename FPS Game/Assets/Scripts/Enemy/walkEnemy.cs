using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            transform.position += Vector3.back * Time.deltaTime;
        }
    }
}
