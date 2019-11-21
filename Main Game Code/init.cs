using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class init : MonoBehaviour {

    public GameObject question1_board;
    //question 1
    public GameObject question2_board;
    //question 2
    public GameObject question3_board;
    //question3 

    public GameObject pasuePanel;
    // pasue panel

    public GameObject HeathBor_reset;
    // set heath baw to default



    // Use this for initialization
    void Awake () {

        // hide quesiton boards
        question1_board.SetActive(false);
        question2_board.SetActive(false);
        question3_board.SetActive(false);

        //hide pasue panel 
        pasuePanel.SetActive(false);

        globe_setting.Time = globe_setting.Time_default;
        Debug.Log("book left:" + globe_setting.home_left.ToString());

        globe_setting.player_health= 333f;
        HeathBor_reset.GetComponent<Image>().rectTransform.localScale = new Vector3(333f, 1, 1);


        globe_setting.user_score = 0;


    }
    



}
