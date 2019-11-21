using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class credits_page_clickevent : MonoBehaviour {

	public void backTOMainmenu()
    {

        SceneManager.LoadScene("loadingscreentoS");
    }

    public void OpenDeveloperWebsite()
    {
        Application.OpenURL("http://fuzhang.co.uk");
    }

    public void OpenFeedbackPage()
    {

        Application.OpenURL("http://fuzhang.co.uk/2017/03/01/softwares-feedbacks/");
    }
}
