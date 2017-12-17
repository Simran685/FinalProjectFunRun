using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newBullet : MonoBehaviour {

    public float speed;
    Rigidbody2D rigidbody2d;
    public float delay = 0.05f;
    public GameObject enemyexploding;
    AudioSource EnemyBlast;
    void start()
    {
        AudioSource [] audioSources = GetComponents<AudioSource>();
        EnemyBlast = audioSources [0];
    }




    void Awake()
    {
        Vector2 dir = GameObject.Find("player").GetComponent<Player>().GetFaceDirection();
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.velocity = dir * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("enemies"))
        {
            //Instantiate(Diamond, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            GameObject ememy1= Instantiate(enemyexploding, collision.transform.position, collision.transform.rotation);
            ememy1.GetComponent<Animator>().SetTrigger("isExploding");
            GameObject.Find("EnemyBlast").GetComponent<AudioSource>().Play();
            






           //Destroy(ememy1, enemyexploding.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
        }
    }
    void Update()
    {

    }
}
