using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toturial_clickevent : MonoBehaviour {

	
    public void LoadGame()
    {

        SceneManager.LoadScene("loadingscreentoM");

    }


    public void GotoMainMenu()
    {

        SceneManager.LoadScene("loadingscreentoS");
    }

}
