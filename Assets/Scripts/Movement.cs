using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update


    private Vector3 pos;
    private Vector3 speed;


    void Start()
    {
    
}

    // Update is called once per frame
    void Update()
    {
        GameObject Dufus = new GameObject("Doofus");
        GameObject Pulpit = new GameObject("Pulpit");
        //GameObject getGameObject(doofus):
        double spwawntime = 0;  // SpawnTime of the Doofus
        double pulpit_spn = 0; // Spawn the pulpit;
        //int pulpit_Score = GetInstanceID(Score);
        double speed = 0;
        

        //double Pos = 0;
        //Instantiate(Pulpit);
        //Instantiate(Dufus);

        
        
       
        speed+=Time.deltaTime;
        //relspeed = speed * pos;

        if (Input.GetKeyDown(KeyCode.W))
        {
            pos = transform.position;
            pos.x++;
            speed++;
        }
        if ((Input.GetKeyDown(KeyCode.S)))
        {
            pos = transform.position;
            pos.x--;

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            pos = transform.position;
            pos.y++;
            speed++;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pos = transform.position;
            pos.y--;
        }



        Console.Write("..");
            if (spwawntime == 0 || pulpit_spn == 0 || pos.x == 0 || pos.y == 0)
            {
                Console.Write("No Value");
                Destroy(Dufus); // Destroy the object 
            }




        //return spwawntime;





    }
}
