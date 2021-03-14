using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Cursor.lockState = CursorLockMode.locked;
        //Cursor.visible = false;
    }
}
