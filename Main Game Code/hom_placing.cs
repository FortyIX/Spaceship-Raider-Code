using UnityEngine;
using System.Collections;

public class hom_placing : MonoBehaviour
{

    public GameObject homework1;
    public GameObject homework2;
    public GameObject homework3;

    //following variable are the originally the position for generating floors
    //but it is also the position of edge for left of screen of floors
    public GameObject Gap_pos_floor;


    public GameObject Screen_f1_edge;
    public GameObject Screen_f2_edge;
    public GameObject Screen_f3_edge;


    void Start()
    {

        float Rnum1, Rnum2, Rnum3;//random num for position of homeworks


        Rnum1 = MakeSuitableRandNumber(Screen_f1_edge.transform.position.x, Gap_pos_floor.transform.position.x);
        //generating a random number for floor 1
        Rnum2 = MakeSuitableRandNumber(Screen_f2_edge.transform.position.x, Gap_pos_floor.transform.position.x);
        //generating a random number for floor 2
        Rnum3 = MakeSuitableRandNumber(Screen_f3_edge.transform.position.x, Gap_pos_floor.transform.position.x);
        //generating a random number for floor 3


        Vector3 pos1 = new Vector3(Rnum1, Screen_f1_edge.transform.position.y + 1, Screen_f1_edge.transform.position.z);
        // generating a position for homework on floor 1
        Vector3 pos2 = new Vector3(Rnum2, Screen_f2_edge.transform.position.y + 1, Screen_f2_edge.transform.position.z);
        // generating a position for homework on floor 2
        Vector3 pos3 = new Vector3(Rnum3, Screen_f3_edge.transform.position.y + 1, Screen_f3_edge.transform.position.z);
        // generating a position for homework on floor 3



        //generating homeworks
        homework1.transform.position = pos1;
        homework2.transform.position = pos2;
        homework3.transform.position = pos3;





    }

    // Update is called once per frame
    void Update()
    {

    }


    // function to check the space between the gap of each floor with the left edge of screen 
    // then return a random value the positio of homework 


    static public float MakeSuitableRandNumber(float first_x_position, float second_x_position)
    {

        if (Mathf.Abs(first_x_position - second_x_position) > 3)
        {

            return Random.Range(second_x_position, 7.18f);



        }

        else
        {

            return Random.Range(first_x_position, second_x_position);
        }
    }

}
