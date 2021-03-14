using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionController : MonoBehaviour
{
    // is complete
    public bool mission1;
    public bool mission2;
    public bool mission3;

    public GameObject mission1check;
    public GameObject mission2check;
    public GameObject mission3check;


    // Start is called before the first frame update
    void Start()
    {
        mission1 = false;
        mission2 = false;
        mission3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(mission1 == true)
        {
            mission1check.SetActive(true);
        }

        if (mission1 == false)
        {
            mission1check.SetActive(false);
        }

        if (mission2 == true)
        {
            mission2check.SetActive(true);
        }

        if (mission2 == false)
        {
            mission2check.SetActive(false);
        }

        if (mission3 == true)
        {
            mission3check.SetActive(true);
        }

        if (mission3 == false)
        {
            mission3check.SetActive(false);
        }
    }
}
