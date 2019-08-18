using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatMissile : MonoBehaviour
{

    GameObject player;
    Vector3 targetPos;
    float distance;

    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
      

        targetPos = player.transform.position;
        distance = Vector3.Distance(targetPos,transform.position);


        if (distance > 10)
            transform.position += (targetPos - transform.position) / 20;
        else
            transform.position += new Vector3(((targetPos.x) - transform.position.x) / 20, transform.position.y/30 , ((targetPos.z) - transform.position.z) / 20);
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Hit Player");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Missed Player");
            Destroy(this.gameObject);
        }
    }
}
