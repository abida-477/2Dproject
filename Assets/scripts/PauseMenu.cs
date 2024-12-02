using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // Checks if the Escape key is pressed during the game.
        {
            if(!pauseMenu.activeSelf) // If the pause menu is not currently active, pause the game and show the menu.
          {
            Time.timeScale=0f;        // Stops all in-game activity.
            pauseMenu.SetActive(true); // Activates the pause menu UI.
           } 
           else  // If the pause menu is already active, resume the game and hide the menu.
           {
             Time.timeScale = 1f;  // Resumes normal in-game activity.
             pauseMenu.SetActive(false); // Deactivates the pause menu UI.
             Cursor.visible = false; // Hides the cursor (optional for games where the cursor is hidden by default).
           }
        }
        
    }
    public void quit() // Method to quit the application when called
    {
    Application.Quit(); // Exits the application.

    }
public void resume()
{
    Time.timeScale = 1f;// Resumes normal in-game activity
    pauseMenu.SetActive(false);// Deactivates the pause menu UI.
    Cursor.visible = false; // Hides the cursor.
}
}