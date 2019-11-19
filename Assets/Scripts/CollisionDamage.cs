using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionDamage : MonoBehaviour
{
    public int hp;
    public AudioSource explosion;
    public int youLose;


    void OnTriggerEnter2D()
    {
        hp--;

    }

    void LateUpdate()
    {
        if (hp <= 0)
        {
            if(youLose == 5)
                SceneManager.LoadScene("YouLose");
            Shatter();
        }
    }
    void Shatter()
    {
        if (explosion)
            explosion.Play();
        Destroy(gameObject);
    }


}
