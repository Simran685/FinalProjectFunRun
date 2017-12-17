using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGun : MonoBehaviour {

    public GameObject bulletprefab;
    public GameObject bombprefab;

    public float delaytime = 0.25f;
 
    Animation ani;

    float cooldown = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        Vector2 newBulletpos;
        newBulletpos.x = transform.position.x ;
        newBulletpos.y = transform.position.y + .5f;

        if (Input.GetButton("Fire1") & cooldown <= 0)
            {
                cooldown = delaytime;
                Instantiate(bulletprefab, newBulletpos, transform.rotation);
                GameObject.Find("player").GetComponent<Animator>().SetTrigger("IsShooting");
        }
        else if (Input.GetButton("Fire2") & cooldown <= 0)
        {
            cooldown = delaytime;
            Instantiate(bombprefab, newBulletpos, transform.rotation);
            GameObject.Find("player").GetComponent<Animator>().SetTrigger("IsShooting");
        }
        }
       
        



    
}