using UnityEngine;
using System.Collections;

public class stop_game : MonoBehaviour {


    public GameObject pasuePanel;


    public void pauseGame()
    {

        Time.timeScale = 0;
       
        pasuePanel.SetActive(true);
    }

    
    public void resumeGame()
    {
        Time.timeScale = 1;
        
        pasuePanel.SetActive(false);

    }
}
