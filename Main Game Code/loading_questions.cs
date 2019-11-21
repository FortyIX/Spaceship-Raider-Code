using UnityEngine;
using System.Collections;
using System.Linq;
using UnityEngine.UI;
using System;

public class loading_questions : MonoBehaviour {

    public string getidURL = "http://fuzhang.co.uk/Connect_database_by_php/get_question_id.php?";
    //php file of getting id of corresopnding difficulty from database
    public string _getimageURL= "http://fuzhang.co.uk/Connect_database_by_php/get_question_image.php?";
    ////php file of getting image of corresopnding id from database
    public string getAnswerURL = "http://fuzhang.co.uk/Connect_database_by_php/get_question_answer.php?";


    public GameObject question1_board;
    public GameObject question2_board;
    public GameObject question3_board;


    void Start()
    {

        int a = globe_setting.Game_Difficulty;
        StartCoroutine(get_id_with_Difficult_of(a.ToString()));
        
        //send game difficulty to get id list of this difficulty
    }


    public IEnumerator get_id_with_Difficult_of(string difficulty)
    {


        string url_sending_difficulty = getidURL + "di=" + difficulty;
            
        //generating a url with parameter of difficulty

        WWW WWW_id = new WWW(url_sending_difficulty);
        // create a WWW object ( with constructor ) 
        

        yield return WWW_id;
        //wait until get something

       
        if (WWW_id.error != null)
        {
            Debug.Log(WWW_id.error);
        }
        else
        {
            Debug.Log(WWW_id.text);
            Ramdom_pick_one_id_in(WWW_id.text);
        

        }

    }

    public void Ramdom_pick_one_id_in(string id_list)
    {
       
        int[] id_list_array = Array.ConvertAll(id_list.Split(','), int.Parse);
        //pick the id up 
        //convert  int strint to int array


       

        int rand = UnityEngine.Random.Range(0, id_list_array.Length-1);
        int rand2 = UnityEngine.Random.Range(0, id_list_array.Length - 1);
        int rand3 = UnityEngine.Random.Range(0, id_list_array.Length - 1);
        // generate 3 random id for 3 questions


        Debug.Log("random id"+rand.ToString());
        Debug.Log("random id" + rand2.ToString());
        Debug.Log("random id" + rand3.ToString());


        StartCoroutine(Get_Image_with_id_of((id_list_array[rand]).ToString(), id_list_array[rand2].ToString(),id_list_array[rand3].ToString()));
        //send 3 random ids to function to load corresponding image

        StartCoroutine(get_answer_with_id_of((id_list_array[rand]).ToString(), id_list_array[rand2].ToString(), id_list_array[rand3].ToString()));

        //send 3 random ids to function to load corresponding answer
    }

    public IEnumerator Get_Image_with_id_of(string id1,string id2,string id3)
    {
        //-------------------------------------------------------
        string url_sending_id1 = _getimageURL + "id=" + id1;
        string url_sending_id2= _getimageURL + "id=" + id2;
        string url_sending_id3 = _getimageURL + "id=" + id3;
        //generating 3 urls with parameter of id

        //--------------------------------------------------------
        

        //--------------------------------------------------------
        WWW WWW_image = new WWW(url_sending_id1);
        WWW WWW_image2 = new WWW(url_sending_id2);
        WWW WWW_image3 = new WWW(url_sending_id3);
        // create 3 WWW object ( with constructor ) 

        //-----------------------------------------------------------
        

        //------------------------------------------------------------
        //process of downloading first question

        yield return WWW_image;
        if (WWW_image.error != null)
        {
            Debug.Log(WWW_image.error);
        }
        else
        {
           // Debug.Log("fist question image done");

            question1_board.GetComponent<Image>().sprite = Sprite.Create(WWW_image.texture,new Rect(0, 0,WWW_image.texture.width, WWW_image.texture.height),new Vector2());

        }
        //--------------------first end---------------------------------


        //------------------------------------------------------------
        //process of downloading second question

        yield return WWW_image2;
        if (WWW_image2.error != null)
        {
            Debug.Log(WWW_image2.error);
        }
        else
        {
           // Debug.Log("second question image done");
            
            question2_board.GetComponent<Image>().sprite = Sprite.Create(WWW_image2.texture, new Rect(0, 0, WWW_image2.texture.width, WWW_image2.texture.height), new Vector2());

        }
        //--------------------second end---------------------------------


        //------------------------------------------------------------
        //process of downloading third question

        yield return WWW_image3;
        if (WWW_image3.error != null)
        {
            Debug.Log(WWW_image3.error);
        }
        else
        {
           // Debug.Log("third question image done");

            question3_board.GetComponent<Image>().sprite = Sprite.Create(WWW_image3.texture, new Rect(0, 0, WWW_image3.texture.width, WWW_image3.texture.height), new Vector2());

        }
        //--------------------third end---------------------------------


    }

    public IEnumerator get_answer_with_id_of(string id1,string id2,string id3)
    {

        string url_sending_answer = getAnswerURL + "id=" + id1;
        string url_sending_answer2 = getAnswerURL + "id=" + id2;
        string url_sending_answer3 = getAnswerURL + "id=" + id3;

        WWW WWW_answer = new WWW(url_sending_answer);
        WWW WWW_answer2 = new WWW(url_sending_answer2);
        WWW WWW_answer3 = new WWW(url_sending_answer3);

        //--------------------------------------------------------------------
        //return answer for first question
        yield return WWW_answer;

        if (WWW_answer.error != null)
        {
            Debug.Log(WWW_answer.error);
        }
        else
        {
            globe_setting.correct_answer_stored = WWW_answer.text;
          //  Debug.Log("first answer done");
            Debug.Log(globe_setting.correct_answer_stored);
        }


        //-------------------------------------------------------------------------

        //--------------------------------------------------------------------
        //return answer for second question
        yield return WWW_answer2;

        if (WWW_answer2.error != null)
        {
            Debug.Log(WWW_answer2.error);
        }
        else
        {
            globe_setting.correct_answer_stored2 = WWW_answer2.text;
           // Debug.Log("second answer done");
            Debug.Log(globe_setting.correct_answer_stored2);
        }


        //-------------------------------------------------------------------------

        //--------------------------------------------------------------------
        //return answer for third question
        yield return WWW_answer3;

        if (WWW_answer3.error != null)
        {
            Debug.Log(WWW_answer3.error);
        }
        else
        {
            globe_setting.correct_answer_stored3 = WWW_answer3.text;
            //Debug.Log("third answer done");
            Debug.Log(globe_setting.correct_answer_stored3);
        }


        //-------------------------------------------------------------------------


    }




}
