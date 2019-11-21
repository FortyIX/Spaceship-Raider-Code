using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using Facebook.Unity;



public class endscene_clickevent : MonoBehaviour {

	public void gotoScoreBoard()
    {
        SceneManager.LoadScene("scoreboard");
    }

    public void restartGame()
    {
        SceneManager.LoadScene("loadingscreentoM");
    }

    public void backToMainMenu()
    {
        SceneManager.LoadScene("loadingscreentoS");
    }



    void Start()
    {

        if (!FB.IsInitialized)
        {
            FB.Init();
        }
        else
        {
            FB.ActivateApp();
        }

    }





    public void FBShare()
    {
        FB.ShareLink(new System.Uri("http://fuzhang.co.uk/MyWebsite/spaceshipRaider.html"),
            contentTitle: "I gained"+globe_setting.user_score+" "+"scores in SpaceShip Raider",
            contentDescription:"Come and download it"
            );

    }



}
