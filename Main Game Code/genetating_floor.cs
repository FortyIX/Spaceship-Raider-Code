using UnityEngine;
using System.Collections;

public class genetating_floor : MonoBehaviour {

    public GameObject f1_pos;
    //position of floor 1
    public GameObject f2_pos;
    //position of floor 2
    public GameObject f3_pos;
    //position of floor 3

    public GameObject floor;


    void Start () {

        float Rnum1 = Random.Range(-6.92f, 7.18f);
        //random num for floor 1
        float Rnum2 = Random.Range(-6.92f, 7.18f);
        //random num for floor 2
        float Rnum3 = Random.Range(-6.92f, 7.18f);
        //random num for floor 3


        Vector3 pos1 = new Vector3(Rnum1, f1_pos.transform.position.y, f1_pos.transform.position.z);
        // generating position for floor 1
        Vector3 pos2 = new Vector3(Rnum2, f2_pos.transform.position.y, f1_pos.transform.position.z);
        // generating position for floor 2
        Vector3 pos3 = new Vector3(Rnum3, f3_pos.transform.position.y, f1_pos.transform.position.z);
        // generating position for floor 3



        //generating floor with their correspondind positions

        Instantiate(floor, pos1,Quaternion.identity);
        Instantiate(floor, pos2, Quaternion.identity);
        Instantiate(floor, pos3, Quaternion.identity);




    }

    // Update is called once per frame
    void Update () {
	
	}
}
