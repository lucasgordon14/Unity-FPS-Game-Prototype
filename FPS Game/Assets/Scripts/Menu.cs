using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public int index = 3;

    public Text playText;
    public Text controlsText;
    public Text settingsText;
    public Text quitText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            index -= 1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index += 1;
        }

        if (index > 3)
        {
            index = 3;
        }

        if (index < 0)
        {
            index = 0;
        }

        if (index == 3)
        {
            playText.color = Color.red;
            settingsText.color = Color.white;
            quitText.color = Color.white;
            controlsText.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("Mission1", LoadSceneMode.Single);
            }
        }

        if (index == 2)
        {
            playText.color = Color.white;
            settingsText.color = Color.white;
            quitText.color = Color.white;
            controlsText.color = Color.red;

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("ControlMenu", LoadSceneMode.Single);
            }
        }


        if (index == 1)
        {
            playText.color = Color.white;
            settingsText.color = Color.red;
            quitText.color = Color.white;
            controlsText.color = Color.white;

            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene("SettingsScreen", LoadSceneMode.Single);
            }
        }

        if (index == 0)
        {
            playText.color = Color.white;
            settingsText.color = Color.white;
            quitText.color = Color.red;
            controlsText.color = Color.white;
        }
    }
}
