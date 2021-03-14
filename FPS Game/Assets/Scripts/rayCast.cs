using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast : MonoBehaviour
{
    public float maxRayDistance = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit whatIHit;
        if(Physics.Raycast(transform.position, transform.forward, out whatIHit, Mathf.Infinity))
        {
            Debug.Log(whatIHit.collider.name);
        }
        /*
        Ray ray = new Ray(transform.position, Vector3.left);
        RaycastHit hit;

        Debug.DrawLine(transform.position, transform.position + Vector3.left * maxRayDistance, Color.red);

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
            
            

            if (Physics.Raycast(ray, out hit, maxRayDistance))
            {
                Debug.Log("Hit");
            }

        //}

    */
    }
}
