using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject missile;

    float timer = 3;


    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer<=0.0f)
        {
            if (!GameObject.Find("missile"))
                Instantiate(missile);

            timer = 2;
        }



     
    }
}
