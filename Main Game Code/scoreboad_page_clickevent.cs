using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scoreboad_page_clickevent : MonoBehaviour {

    public GameObject hiden_login_panel;

    public void gotoMainMenu()
    {
        SceneManager.LoadScene("loadingscreentoS");
        


    }

    public void gotoEndScene()
    {

        SceneManager.LoadScene("endScene");
    }

    public void OpenSignUpURL()
    {
        Application.OpenURL("http://fuzhang.co.uk/SPR_Uploader/studentAccount/SignUp/studentSignUp.php");


    }

  


    public void OpenLoginPanel()
    {

        hiden_login_panel.SetActive(true);

    }



    public void CloseLoginPanel()
    {
        hiden_login_panel.SetActive(false);
    }



}


