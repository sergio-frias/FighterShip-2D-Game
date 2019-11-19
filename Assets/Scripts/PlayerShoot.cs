using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject laserPrefab;

    public int ammo;

    
    public AudioSource laser;
    public AudioSource noAmmo;

    private void Start()
    {
       // ammo = 10;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (ammo > 0)
            {
                ammo--;
                laser.Play();
                Instantiate(laserPrefab, transform.position, transform.rotation);
            }

            else
                noAmmo.Play();


            
        }

        


    }
}
