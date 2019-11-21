using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemies_attack_checker : MonoBehaviour {


    public GameObject enemy;
    // profab of enemy
    public float ene_Hp=30f;
    //HP value left of enemy

    Animator ani;
    // used for play dying animation

    private bool is_enemy_died=false;
    



    void OnTriggerEnter2D(Collider2D bullet)
    {
        //if enemies are being shoot 
        if (bullet.tag == "bullets")
        {
            Takedamage();
            //it they are
            // take damage

        }
    }

   

    
    

    public void Takedamage()
    {
        ani = enemy.GetComponent<Animator>();
        //find the animator
        
        ene_Hp-=globe_setting.Ene_sho_damage;
        //lose HP with damage

        Debug.Log(ene_Hp);
        if (ene_Hp < 0)
        {
            ene_Hp = 0;
        
            ani.SetBool("die", true);
                
            // after animation playered,destopy this enemy in 0.6 seconds 
            Destroy(enemy,0.69f);


        }
       
    }

}

