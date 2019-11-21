using UnityEngine;
using System.Collections;

public class exit_door_collide_check : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D player)
    {

       
        if (player.tag == "Player")
        {
            globe_functions.ExitFromdoor();
        }
    }
}
