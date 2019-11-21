using UnityEngine;
using System.Collections;

public class question_trigger_1 : MonoBehaviour {

    public GameObject question1_board1;
    public GameObject question2_board1;
    public GameObject question3_board1;

    public GameObject pausemenu;


  
    void OnTriggerEnter2D(Collider2D player)
    {
        
        if (player.tag == "Player")
        {

            question1_board1.SetActive(true);
            question2_board1.SetActive(false);
            question3_board1.SetActive(false);
            pausemenu.SetActive(false);

        }
    }
}
