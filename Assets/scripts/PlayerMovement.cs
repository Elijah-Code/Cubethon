using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // adjustable force variables inside the unity inspector
    public float forwardForce = 4000f;
    public float sidewaysForce = 100f;

    // Update is called once per frame
    void FixedUpdate() // FixedUpdate instead of Update because we use unity physics engine
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a forward force

        if ( Input.GetKey(KeyCode.RightArrow) )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // if d is pressed, move right. VelocityChange to make it more responsive (ignoring the mass)
        }

        if ( Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // if a is pressed, move left. VelocityChange to make it more responsive (ignoring the mass)
        }

    }
}
