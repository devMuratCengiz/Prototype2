using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float verticalInput;

    public float speed = 20f;

    private float xRange = 22f;

    public GameObject Pizza;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z <= -12.5)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -12.5f);
        }
        if (transform.position.z >= 25)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25f);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Pizza, transform.position, Quaternion.identity);
            
        }
    }
    
}
