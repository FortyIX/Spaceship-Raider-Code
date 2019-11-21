using UnityEngine;
using System.Collections;

public class globe_setting : MonoBehaviour {

    // default value for the health which player have

    static public float player_health = 333f;
    //answer for first question stored in database
    static public string correct_answer_stored;
    
    //answer for second question stored in database
    static public string correct_answer_stored2;
    
    //answer for third question stored in database
    static public string correct_answer_stored3;

    // defalut value for the health which enemies have
    static public float enemy_health = 50f;

    //difficulty of the game
    static public int Game_Difficulty=3;

    // default value for the time of a round
    static public int Time_default=420;

    //current time left
    static public float Time;

    //current homeworks left
    static public int home_left = 3;

    //damage of the gun 
    static public float Ene_sho_damage = 10f;

    //scores user has got
    static public int user_score = 0;
   
    //posistion of player;
    static public Vector3 player_pos;

    //define the full HP user could have
    static public float full_HP_init = 333f;

    //the auto-difficulty setting
    static public bool auto_diffi;

    static public bool question_refreash;




}
