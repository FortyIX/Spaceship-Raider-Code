using UnityEngine;
using System.Collections;

public class Player_movement : MonoBehaviour {

    public bool facingright = true;
    public float speed = 1f;
    public float temp_move;
    public int face_bullet_direction = 1;
    //  default vales for movement 

    public float _horizontalMovement;
    public float _verticalMovement;

    public Transform bullet_spawn_point;
    public GameObject bullet_profab;


    public virtual void Move(Vector2 newMovement)
    {
        
            _horizontalMovement = newMovement.x;
            _verticalMovement = newMovement.y;
        
    }


    public void flip()
    {
        //changing the direction of facing 
        facingright = !facingright;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        

        // changing the direction of shooting bullets at same time 
        if (facingright == false) { face_bullet_direction = -1; }
        if (facingright == true)  { face_bullet_direction = 1; }

    
    }
    

    public void fire()
    {
        var bullet = (GameObject)Instantiate(bullet_profab,bullet_spawn_point.position,bullet_spawn_point.rotation);
        // instantiate a bullet as projectile 
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(35*face_bullet_direction, 0);
        GetComponent<AudioSource>().Play();

        Destroy(bullet, 3f);
       
    }

    public void jump()
    {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8);
    }


    // Update is called once per frame
    void Update () {

        globe_setting.player_pos = transform.position;

        //get user input
        float move =_horizontalMovement * speed;
        //move with these inputs
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, GetComponent<Rigidbody2D>().velocity.y);


        //check which direction is player heading 
        if (move > 0 && !facingright)
        {
            flip();
            
        }
        if (move < 0 && facingright)
        {
            flip();
           
        }


        //jump of player 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        // shooting 
        if (Input.GetKeyDown(KeyCode.J))
        {
            fire();
        }



    }
}
