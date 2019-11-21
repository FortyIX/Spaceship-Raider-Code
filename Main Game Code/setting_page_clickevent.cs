using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class setting_page_clickevent : MonoBehaviour {


    public GameObject trigger_auto_diff;
    public GameObject trigger_question_re;

    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("autoDF"));

        switch (PlayerPrefs.GetInt("autoDF"))
        {

            

            case 1:
                trigger_auto_diff.GetComponent<Toggle>().isOn = true;

                break;

            case 0:
                trigger_auto_diff.GetComponent<Toggle>().isOn = false;

                break;
        }

        switch (PlayerPrefs.GetInt("QuesRE")) {


            case 1:

                trigger_question_re.GetComponent<Toggle>().isOn = true;

                break;

            case 0:

                trigger_question_re.GetComponent<Toggle>().isOn = false;
                break;


        }



        


    }


    public void OpenTandCURL()
    {


        //open T&C URL
        Application.OpenURL("http://fuzhang.co.uk/MyWebsite/SPR-terms-conditions-english.html");



    }
}
