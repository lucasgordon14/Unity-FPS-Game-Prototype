using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBall : MonoBehaviour
{
    public Transform trans;
    //public MeshRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        // this.gameObject.SetActive(false);
        //rend.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        int index = 1;
        index += 1;

        if (index == 2)
        {
            trans.position = new Vector3(28, 1.2f, 12);
            index = 2;

            Debug.Log(index);
            
        }

        if (index == 3)
        {
            trans.position = new Vector3(-16.96f, 1.2f, 12.71f);
            index = 3;
        }
        /*
        if (index == 1)
        {
            trans.position = new Vector3(-16.96f, 1.2f, 12.71f);
            //index = 2;
        }
        */
    }

    private void OnTriggerEnter(Collision collision)
    {
       
    }
}
