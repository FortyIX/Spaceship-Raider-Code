using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player_bullet_checker : MonoBehaviour {

    public GameObject left_hp_bar;
    public GameObject player_itself;



    public float full_HP = globe_setting.full_HP_init;

    void Start()
    {

        uploadHealthbar();

    }



    void OnTriggerEnter2D(Collider2D bullet)
    {

        
        if (bullet.tag == "enemy_bullets")
        {
            Takedamage();
            
        }
    }


    private void uploadHealthbar()
    {
        float ratio = globe_setting.player_health / full_HP;

        left_hp_bar.GetComponent<Image>().rectTransform.localScale = new Vector3(ratio, 1, 1);




    }

    public void Takedamage()
    {
        globe_setting.player_health -= globe_setting.Ene_sho_damage;
        uploadHealthbar();
    }

}

