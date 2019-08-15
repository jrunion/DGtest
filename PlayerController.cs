using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 10f;

    float mouseInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        this.transform.position += Movement * speed * UnityEngine.Time.deltaTime;

        mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookhere = new Vector3(0, mouseInput, 0);
        transform.Rotate(lookhere);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 up = transform.TransformDirection(Vector3.up);
            GetComponent<Rigidbody>().AddForce(up * 5, ForceMode.Impulse);
        }
    }
}
