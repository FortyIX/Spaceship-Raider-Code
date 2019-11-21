using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class internet_checker : MonoBehaviour {

    public GameObject no_in_panel;
    public GameObject internet_conn_method;
    public GameObject internet_icon;

    public int gamestatus;


    // Update is called once per frame


    void Start()
    {

        Debug.Log("This scipt is runing ");

    }

    void Update()
    {

        if (Application.internetReachability == NetworkReachability.NotReachable)
        {

            Color orange = new Color(219, 72, 24);
            
            //background color 
            no_in_panel.GetComponent<RawImage>().color = orange;
            
            //change status indictor
             internet_icon.GetComponent<Image>().color = Color.red;
             internet_conn_method.GetComponent<Text>().text = "Offline";
            // show notice
            no_in_panel.SetActive(true);

            // stop game
            pausegame(0);

            

        }

    

        else if (Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            
            internet_conn_method.GetComponent<Text>().text = "Wifi";
            internet_icon.GetComponent<Image>().color = Color.green;
            no_in_panel.SetActive(false);
            if (gamestatus == 0)
            {
                pausegame(1);
                
            }



        }

        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
        {

            internet_conn_method.GetComponent<Text>().text = "Mobile Data";
            internet_icon.GetComponent<Image>().color = Color.green;
            no_in_panel.SetActive(false);
            if (gamestatus == 0)
            {
                pausegame(1);
               
            }

        }





    }

     public void pausegame(int switcher)
    {

        gamestatus = switcher;
        Time.timeScale = switcher;


    }


}
