using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    [SerializeField] GameObject scoreObject;
    Rigidbody rb;
    float forwardSpeed;
    float basicSpeed;
    float sideSpeed;
    private bool clicked;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        forwardSpeed = 10.0f;
        basicSpeed = 10.0f;
        sideSpeed = 150.0f;
        clicked = false;
    }

    private void Update()
    {
        if (scoreObject.GetComponent<UIManager>().score >= 10 && scoreObject.GetComponent<UIManager>().score < 25)
        {
            forwardSpeed = basicSpeed * 1.5f;
        }
        if (scoreObject.GetComponent<UIManager>().score >= 25 && scoreObject.GetComponent<UIManager>().score < 50)
        {
            forwardSpeed = basicSpeed * 2.0f;
        }
        if (scoreObject.GetComponent<UIManager>().score >= 50 && scoreObject.GetComponent<UIManager>().score < 100)
        {
            forwardSpeed = basicSpeed * 3.0f;
        }
        if (scoreObject.GetComponent<UIManager>().score >= 100)
        {
            forwardSpeed = basicSpeed * 4.0f;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (clicked == false)
            {
                clicked = true;
            }
            else if (clicked == true)
            {
                clicked = false;
            }
        }

        if (clicked == false)
        {
            sideSpeed += 2.0f;
        }
        if (clicked == true)
        {
            sideSpeed -= 2.0f;
        }

        if (sideSpeed >= 150.0f)
        {
            sideSpeed = 150.0f;
        }
        if (sideSpeed <= -150.0f)
        {
            sideSpeed = -150.0f;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Floor1" && collision.gameObject.name != "Floor2")
        {
            UIManager.instance.DecreaseLives();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, forwardSpeed);
        rb.AddForce(Vector3.left * sideSpeed);
    }
}
