using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agreement_panel : MonoBehaviour {


    public GameObject agreement_show_panel;

  



     void Start()
    {

        agreement_show_panel.SetActive(false);


        //Check if this is the first time that user run this game 
        if (PlayerPrefs.GetInt("saved_first_run") == 0){


            agreement_show_panel.SetActive(true);

            PlayerPrefs.SetInt("saved_first_run", 1);

        }


    }










}
