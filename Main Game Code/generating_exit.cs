using UnityEngine;
using System.Collections;

public class generating_exit : MonoBehaviour {

    public GameObject exit_door;
    public GameObject pos_floor;

    public GameObject f3_edge;


	// Use this for initialization
	void Start () {

        float randnum1 = hom_placing.MakeSuitableRandNumber(f3_edge.transform.position.x, pos_floor.transform.position.x);
        //a random x cooordinate.mabe by using same function which book generating use

        Vector3 pos_exit = new Vector3(randnum1, f3_edge.transform.position.y+1.1f, f3_edge.transform.position.z);
        //generating a position
        
        Instantiate(exit_door, pos_exit, Quaternion.identity);
        //instantiate 


    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
