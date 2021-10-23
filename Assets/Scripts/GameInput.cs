using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Backspace == Restart
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            //current scene
            int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
            //reload scene
            SceneManager.LoadScene(currentLevelIndex);
        }
        // Esc == Exit app
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit the game");
            Application.Quit();
        }
    }
}
