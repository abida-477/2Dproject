using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxtime = 5f;
    float timeleft;
    private float stime;
    public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);  // Ensures the "Times Up" text is hidden at the start.
        timerBar = GetComponent<Image>();  // Gets the Image component for the timer bar.
        timeleft = maxtime;  // Sets the starting time to the maximum time.
    }
  

    // Update is called once per frame
    void Update()
    {
        if (timeleft > 0) // If there is time left, decrement the timer and update the timer bar fill.
        {
            timeleft-= Time.deltaTime; // Decreases timeleft by the time passed since the last frame.
            timerBar.fillAmount = timeleft / maxtime; // Updates the fill amount of the timer bar proportionally.
        }
        
    
        else // If the timer reaches zero.
        {
            timesUpText.SetActive(true); // Displays the "Times Up" text.
            Time.timeScale = 0;  // Pauses the game by stopping the passage of time.
        }
}
}