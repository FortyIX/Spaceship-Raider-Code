using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class difficuty_setting : MonoBehaviour {



    public GameObject trigger_auto_diff;
    public GameObject trigger_question_re;

    public virtual void changingDifficulty(int option)
    {

        switch (option) {
            case 0:
                globe_setting.Game_Difficulty = 1;
                break;
            case 1:
                globe_setting.Game_Difficulty = 2;
                break;
            case 2:
                globe_setting.Game_Difficulty = 3;
                break;
            case 3:
                globe_setting.Game_Difficulty = 4;
                break;
            case 4:
                globe_setting.Game_Difficulty = 5;
                break;

              
        }
        Debug.Log(globe_setting.Game_Difficulty);
    }



    public virtual void trigger_autoDiff(bool a)
    {

      

        switch (a) {

            case true:

                PlayerPrefs.SetInt("autoDF", 1);
                trigger_question_re.GetComponent<Toggle>().isOn = false;

                break;

            case false:
                PlayerPrefs.SetInt("autoDF", 0);

                break;


        }




    }

    public virtual void trigger_questionRefreash(bool a)
    {

       
       
        switch (a)
        {

            case true:

                PlayerPrefs.SetInt("QuesRE", 1);
                trigger_auto_diff.GetComponent<Toggle>().isOn = false;

                break;

            case false:
                PlayerPrefs.SetInt("QuesRE", 0);
                

                break;


        }
    }


    public void backtoMainMenu()
    {

        SceneManager.LoadScene("loadingscreentoS");

    }
}
