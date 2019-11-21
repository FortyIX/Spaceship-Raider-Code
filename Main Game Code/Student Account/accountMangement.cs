using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accountMangement : MonoBehaviour {

    #region PHP file URL

    public string getUserStatuesURL = "http://fuzhang.co.uk/Connect_database_by_php/get_login_status_by_usern.php?";
    //php file of getting user login status
    public string PostUserStatuesURL = "http://fuzhang.co.uk/Connect_database_by_php/post_logom_status_by_nameu.php?";
    ////php file of changing user login status
    public string GetUserPwURL = "http://fuzhang.co.uk/Connect_database_by_php/get_userpw_by_un.php?";
    // Php file of getting stored password of user who is tring to login 

    public string GetscoresURL = "http://fuzhang.co.uk/Connect_database_by_php/get_score.php";

    public string PostscoreURL = "http://fuzhang.co.uk/Connect_database_by_php/post_score.php?";

    #endregion

    #region Variables
    public GameObject userName;
    // username inputfield
    public GameObject passWord;
    //password inputfield

    public GameObject greetWord;
    //a place where show welcome to player after their login

    public GameObject hidden_login_panel;
    // login panel which will be hidden at the beginning
    
    public GameObject hidden_logoff_button;
    //Log off button which will not be shown until user successfully logged in 

    public GameObject log_in_button;
    // Log in button which will be hidden after user successfully logged in
    public GameObject user_name_indicater;
    //the place where showing the username of the user who is currently logged in 

    public GameObject LoggedinNotice;
    // a notification that will be shown when user type the wrong password or username

    public GameObject RankWall;

    public bool isInputCorrect;
    // an variable that recording if user's type match the stored password

    public string statusCode;
    //user's login status

    public string tmp_logedin_acc="unknown";
    //an varable that is used to record temprarily who is currently online 




    #endregion


    #region init
    // Use this for initialization
    void Start () {

        // hidden login panel and log off button 
        hidden_login_panel.SetActive(false);
        hidden_logoff_button.SetActive(false);

        //check if user has logged in 
        StartCoroutine(check_user_status_with(tmp_logedin_acc));

        //update score board
        StartCoroutine(get_scores());

    }
    #endregion

    #region get user login status
    //get the status code from database 
    public IEnumerator check_user_status_with(string username)
    {


        string url_status_che = getUserStatuesURL + "usern=" + username;

        //generating a url with parameter of difficulty

        WWW WWW_status_get = new WWW(url_status_che);
        // create a WWW object ( with constructor ) 


        yield return WWW_status_get;
        //wait until get something


        if (WWW_status_get.error != null)
        {
            Debug.Log(WWW_status_get.error);
        }
        else
        {
            Debug.Log(WWW_status_get.text);

            statusCode = WWW_status_get.text;
            CheckStatusCode(statusCode);
        }

    }

    #endregion


    #region Login in Process

    // Login button
    public void Login()
    {


        StartCoroutine(check_user_possword_with(userName.GetComponent<InputField>().text));
        //call login process

        tmp_logedin_acc = userName.GetComponent<InputField>().text;

      
    }


    //log in process
    public IEnumerator check_user_possword_with(string username)
    {


        string url_check_acc = GetUserPwURL + "usern=" + username;

        //generating a url with parameter of difficulty

        WWW WWW_pw = new WWW(url_check_acc);
        // create a WWW object ( with constructor ) 


        yield return WWW_pw;
        //wait until get something


        if (WWW_pw.error != null)
        {
            Debug.Log(WWW_pw.error);
        }
        else
        {
            Debug.Log(WWW_pw.text);
            isInputCorrect = checkInputWith(WWW_pw.text);
            if (isInputCorrect)
            {
                StartCoroutine(Set_logIn_Status_code("301", username));
                StartCoroutine(post_scores(username));
                StartCoroutine(get_scores());
            }

            else
            {
                LoggedinNotice.GetComponent<Text>().text = "Wrong possword or username,please try again";

               
            }

            userName.GetComponent<InputField>().text = "";
            // clear the original input
            passWord.GetComponent<InputField>().text = "";
            // clear the original input
        }

    }



    //Check if the user input password match thie stored password
    public bool checkInputWith(string password)
    {

        
        if (passWord.GetComponent<InputField>().text == password)
        {
            // Debug.Log(possWord.GetComponent<InputField>().text);
         

            return true;

        } 
        else
        {
           // Debug.Log("false");
            return false;

        }


    }

    #endregion

    #region set user login status
    //set user's login status
    public IEnumerator Set_logIn_Status_code(string code,string username)
    {


        string set_sta_URL = PostUserStatuesURL + "sta=" + code+"&"+"usern="+username;

        //generating a url with parameter of difficulty

        WWW WWW_set_status = new WWW(set_sta_URL);
        // create a WWW object ( with constructor ) 


        yield return WWW_set_status;
        //wait until get something


        if (WWW_set_status.error != null)
        {
            Debug.Log(WWW_set_status.error);
        }
        else
        {
            Debug.Log("set status done");
            StartCoroutine(check_user_status_with(username));
        }



    }


    #endregion


    #region Logg off process
    //log off button
    public void LogOff()
    {

        string loggedin_code = "302";
        StartCoroutine(Set_logIn_Status_code(loggedin_code, tmp_logedin_acc));

    }

    #endregion


    #region check status code for further action
    void CheckStatusCode(string status)
    {

        switch (status)
        {
            case "301":
               

                hidden_login_panel.SetActive(false);
                hidden_logoff_button.SetActive(true);
                log_in_button.SetActive(false);
                user_name_indicater.GetComponent<Text>().text = tmp_logedin_acc;
                greetWord.GetComponent<Text>().text = "Welcome";
                break;

            case "302":
                hidden_login_panel.SetActive(false);
                hidden_logoff_button.SetActive(false);
                log_in_button.SetActive(true);
                user_name_indicater.GetComponent<Text>().text = "UnKnown User";
                greetWord.GetComponent<Text>().text = "Please log in";
                break;

        }


    }

    #endregion



    #region post scores


    public IEnumerator post_scores(string username)
    {



       
        string url_Postscore = PostscoreURL + "sco=" + globe_setting.user_score+"&"+"usern="+username;

        //generating a url with parameter of difficulty

        WWW WWW_Postscore = new WWW(url_Postscore);
        // create a WWW object ( with constructor ) 


        yield return WWW_Postscore;
        //wait until get something


        if (WWW_Postscore.error != null)
        {
            Debug.Log(WWW_Postscore.error);
        }
        else
        {
            Debug.Log("post score done");

            
        }

    }


    #endregion


    #region get score

    public IEnumerator get_scores()
    {


        string url_getscore = GetscoresURL;

        //generating a url with parameter of difficulty

        WWW WWW_getscore = new WWW(url_getscore);
        // create a WWW object ( with constructor ) 


        yield return WWW_getscore;
        //wait until get something


        if (WWW_getscore.error != null)
        {
            Debug.Log(WWW_getscore.error);
        }
        else
        {

            RankWall.GetComponent<Text>().text = WWW_getscore.text;


        }

    }


    #endregion


}
