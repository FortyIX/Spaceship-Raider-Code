using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_scene_clickevent : MonoBehaviour {

    //check if player click button for starting game a
    
    public bool isgotototurialpage = false;

    public GameObject agreement_show_panel;
    public GameObject No_internet_connection_panel;

    public GameObject Connection_method;
    public GameObject Connection_status_icon;




    void Start()
    {
        No_internet_connection_panel.SetActive(false);
        
        

       
        StartCoroutine(asyncliadForTutorialPage());
        // start preload asynchronously


    }

    void Update()
    {
        

        if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        {
            Connection_method.GetComponent<Text>().text = "Mobile Data";
            Connection_status_icon.GetComponent<Image>().color = Color.green;
            No_internet_connection_panel.SetActive(false);

        }

        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            Connection_method.GetComponent<Text>().text = "WiFi";
            Connection_status_icon.GetComponent<Image>().color = Color.green;
            No_internet_connection_panel.SetActive(false);

        }

        else if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            No_internet_connection_panel.SetActive(true);
            Connection_method.GetComponent<Text>().text = "Offline";
            Connection_status_icon.GetComponent<Image>().color = Color.red;
        }
    }


    public void StartGame()
    {
        //start game 
        isgotototurialpage = true;

    }

    public void goToSetting()
    {
    // go to setting page
      SceneManager.LoadScene("settingScene");
    }

    public void goToCredits()
    {
        SceneManager.LoadScene("loadingscreentoC");
    }

    public void gotoHighscore()
    {
        // go to score board page
        SceneManager.LoadScene("scoreboard");
    }

    public void OpenTandCURL()
    {
        //open T&C URL
        Application.OpenURL("http://fuzhang.co.uk/MyWebsite/SPR-terms-conditions-english.html");
    }

    public void CloseAgreementPanel()
    {
        agreement_show_panel.SetActive(false);

    }

  




#region Asynchronously preload


  
    // Preload the toturial page asynchronously 

    IEnumerator asyncliadForTutorialPage()
    {

        AsyncOperation asyncfortutroial = SceneManager.LoadSceneAsync("tutorial_page");

        asyncfortutroial.allowSceneActivation = false;

        while (!asyncfortutroial.isDone)
        {

            Debug.Log(asyncfortutroial.progress);

            if (asyncfortutroial.progress == 0.9f)
            {

               
                

                //if user click the button start 
                if (isgotototurialpage == true)
                {

                    //show the page which has beeen preloaded 
                    asyncfortutroial.allowSceneActivation = true;

                }

            }

            yield return null;

        }



    }
}

#endregion