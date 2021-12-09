using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SocialPlatforms;

public class WaveScript : MonoBehaviour
{
    //Hintergrund f�hrt von rechts nach links durch das Bild, Player l�uft auf der Stelle
    //Random Geist spawnd und f�hrt von rechts nach links durch das Bild
    //Geist reagiert auf das Winken und T�r �ffnet sich - Level geschafft
    // Arme initialisieren
    public GameObject NormalArm;
    public GameObject WaveArm;
	public GameObject player;
    public float speed; // speed for Player

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        GetComponent<BoxCollider>().enabled = false; // disables the BoxCollider 
    }

    // Update is called once per frame
    void Update()
    { 
        player.transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World); //move Forward

        //Normaler Arm wird ausgeblendet, solange Leertaste gedr�ckt ist. 
        //Winkender Arm wird angezeigt, solange die Leertaste gedr�ckt ist. 

        if (Input.GetKey(KeyCode.Space))
        {
            NormalArm.SetActive(false);
            WaveArm.SetActive(true);
            GetComponent<BoxCollider>().enabled = true; // enables the Box Collider, scoring is possible

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            NormalArm.SetActive(true);
            WaveArm.SetActive(false);
            GetComponent<BoxCollider>().enabled = false; // disables the BoxCollider, no scoring possible
        }
    }
}
