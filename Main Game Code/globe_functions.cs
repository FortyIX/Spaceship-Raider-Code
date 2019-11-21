using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class globe_functions : MonoBehaviour {

    public GameObject player_itself;
    public GameObject showTime;

    void Update()
    {

       
        // set game time to default time
        globe_setting.Time -= Time.deltaTime;
        //count down per frame
        
        showTime.GetComponent<Text>().text = (Convert.ToInt16(globe_setting.Time)/60).ToString() + " "+"Mins"+" " + ((Convert.ToInt16(globe_setting.Time) % 60).ToString()+ " " + "Secs");
        //show count down on the screen

        if (globe_setting.player_health < 0)
        {
            //if player run out health,player die
            globe_setting.player_health = 0;

            EndGame();
            //destroy the gameobject of player
            Destroy(player_itself);
        }


        if (globe_setting.Time <= 0)
        {
            //if run out of time,end game
            EndGame();
        }



    }


    static public void AddScore()
    {

        int difficulty = globe_setting.Game_Difficulty;

        switch (difficulty)
        {

            case 1:
                globe_setting.user_score += 10;
                break;

            case 2:
                globe_setting.user_score += 20;
                break;
            case 3:
                globe_setting.user_score += 50;
                break;
            case 4:
                globe_setting.user_score += 100;
                break;
            case 5:
                globe_setting.user_score += 300;
                break;

        }


        

    }
  

   static public void ExitFromdoor()

    {

        if (globe_setting.home_left == 0)
        {

            int time_left = Convert.ToInt16(globe_setting.Time);
            globe_setting.user_score += (100 + time_left);      
            EndGame();
        }
    

    }


    static public void EndGame()
    {

        SceneManager.LoadScene("endScene");

    }


    public void endGameFromPasue()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("endScene");

    }




}
