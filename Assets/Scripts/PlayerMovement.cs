using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed;
    public float moveSidewaysForce;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveSidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-moveSidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
