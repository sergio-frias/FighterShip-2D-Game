using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoCollision : MonoBehaviour
{
    public int hp;
    public AudioSource explosion;

    GameObject player;
    PlayerShoot ammoScript;
    CollisionDamage noDamage;

    void Start()
    {
       player = GameObject.Find("FighterJet");
       ammoScript = player.GetComponent<PlayerShoot>();
       noDamage = player.GetComponent<CollisionDamage>();
    }

    void OnTriggerEnter2D()
    {
        noDamage.hp += 1;
        hp--;
        ammoScript.ammo += 5;

    }

    void Update()
    {
        if (hp <= 0)
        {
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
