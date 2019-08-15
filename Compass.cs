using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{

    public GameObject player;
    public GameObject text;
    Text degree;
    
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Degrees");
        player = GameObject.Find("player");
        degree = text.GetComponent<Text>();
        degree.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        rotation = player.transform.eulerAngles.y;

        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotation * -1);

        DegreeText();
    }

    void DegreeText()
    {
        if(transform.eulerAngles.z >=45)
            degree.text = Mathf.Round(360+(transform.eulerAngles.z -45f)*-1).ToString();
        else
            degree.text = Mathf.Round(360+(transform.eulerAngles.z + 315f)*-1).ToString();

    }
}
