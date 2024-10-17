using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed;
    public float moveSidewaysForce;
    private bool _moveRight;
    private bool _moveLeft = false;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    private void Update()
    {
        RightMovement();
        LeftMovement();
    }

    private void RightMovement()
    {
        if (Input.GetKeyDown("d"))
        {
            _moveRight = true;
        }

        if (Input.GetKeyUp("d"))
        {
            _moveRight = false;
        }
    }
    private void LeftMovement()
    {
        if (Input.GetKeyDown("a"))
        {
            _moveLeft = true;
        }

        if (Input.GetKeyUp("a"))
        {
            _moveLeft = false;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        AddConstantForwardForce();
        AddRightForce();
        AddLeftForce();
        if (rb.position.y < -1)
        {
            FindObjectsByType<GameManager>(FindObjectsSortMode.None)[0].EndGame();

        }
    }

    private void AddLeftForce()
    {
        if (_moveLeft)
        {
            rb.AddForce(-moveSidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void AddRightForce()
    {
        if (_moveRight)
        {
            rb.AddForce(moveSidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

    private void AddConstantForwardForce()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
    }
}
