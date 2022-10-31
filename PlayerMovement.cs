using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // reference to the rigidbody component called "rb"
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
     public void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey ("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey ("a") )
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
