using UnityEngine;
using System.Collections;


public class enemies_movement : MonoBehaviour {
    public bool facingright = true;
    // tell the flip function the heading direction
    public int face_bullet_direction = 1;
    // bullet direction
    int facing = 1;
    //tell the enemy current direction 

     //bullet info
    public GameObject bullet_profab;
    public Transform bullet_spawn_point;

    
    public float speed = 1f;
    //moving spped

   
    

    public float fireRate = 0.3f;
    // fire rate

    private float lastShot = 0.0f;


    // Use this for initialization
    void Start () {
       

	}
	
	// Update is called once per frame
	void Update () {

        Animator anim;
        anim = GetComponent<Animator>();

        var x_auto = Time.deltaTime * speed*0.1f;

        //define the speed
        anim.SetBool("run", false);
        //check if player is in attack range
        if (Mathf.Abs(transform.position.x - globe_setting.player_pos.x) < 5f && Mathf.Abs(transform.position.y - globe_setting.player_pos.y) < 1f)
        {
            anim.SetBool("run", true);

            //if it is,ckeck which side of this enemy player is 
            if (transform.position.x > globe_setting.player_pos.x)
            {
                if (facing == 1)
                {
                    flip();
                    facing = -1;
                    
                }
                transform.Translate(-1 * x_auto, 0, 0);
                //moving with player's direction
               
                fire();
                //attack
            }



            else if (transform.position.x < globe_setting.player_pos.x)
            {
                anim.SetBool("run", true);
                if (facing == -1)
                {
                    flip();
                    facing = 1;
                    
                }
                transform.Translate(1 * x_auto, 0, 0);
                //moving with player's direction

                fire();
                //attack

            }

        }
      
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
        if (facingright == true) { face_bullet_direction = 1; }


    }


    void fire()
    {

        if (Time.time > fireRate + lastShot)
        {
            var bullet = (GameObject)Instantiate(bullet_profab, bullet_spawn_point.position, bullet_spawn_point.rotation);
            // instantiate a bullet as projectile 
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(35 * face_bullet_direction, 0);

            GetComponent<AudioSource>().Play();

            Destroy(bullet, 3f);
            lastShot = Time.time;
        }

    }
}
