﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    GameObject player;
    PlayerShoot ammoScript;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FighterJet");
        ammoScript = player.GetComponent<PlayerShoot>();
    }
    void Awake()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ammoScript.ammo.ToString();
    }
}
