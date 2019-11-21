using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class showscore : MonoBehaviour {


    public GameObject showQuestion;
    
    
    void Start()
    {

        showQuestion.GetComponent<Text>().text = globe_setting.user_score.ToString();
        
    }
}
