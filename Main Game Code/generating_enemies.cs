using UnityEngine;
using System.Collections;

public class generating_enemies : MonoBehaviour {

    public GameObject enemies_profabs;

    //following variable are the originally the position for generating floors
    //but it is also the position of edge for left of screen of floors
    public GameObject Screen_edge_pos1;
    public GameObject Screen_edge_pos2;
    public GameObject Screen_edge_pos3;

    public GameObject floor_pos;


    void Start()
    {

        float Rnum1, Rnum2, Rnum3;//random num for position of homeworks


        Rnum1 = hom_placing.MakeSuitableRandNumber(Screen_edge_pos1.transform.position.x, floor_pos.transform.position.x);
        //generating a random number for floor 1
        Rnum2 = hom_placing.MakeSuitableRandNumber(Screen_edge_pos2.transform.position.x, floor_pos.transform.position.x);
        //generating a random number for floor 2
        Rnum3 = hom_placing.MakeSuitableRandNumber(Screen_edge_pos3.transform.position.x, floor_pos.transform.position.x);
        //generating a random number for floor 3


        Vector3 pos1 = new Vector3(Rnum1, Screen_edge_pos1.transform.position.y + 1, Screen_edge_pos1.transform.position.z);
        // generating a position for homework on floor 1
        Vector3 pos2 = new Vector3(Rnum2, Screen_edge_pos2.transform.position.y + 1, Screen_edge_pos2.transform.position.z);
        // generating a position for homework on floor 2
        Vector3 pos3 = new Vector3(Rnum3, Screen_edge_pos3.transform.position.y + 1, Screen_edge_pos3.transform.position.z);
        // generating a position for homework on floor 3



        //generating homeworks

        Instantiate(enemies_profabs, pos1, Quaternion.identity);
        Instantiate(enemies_profabs, pos2, Quaternion.identity);
        Instantiate(enemies_profabs, pos3, Quaternion.identity);




    }


}
