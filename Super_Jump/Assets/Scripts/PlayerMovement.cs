using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    public float mov;
    public Joystick joystick;
    public float jump = 2f;
    public float slow = 15;
    public float forwardForce = 2000f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;  // Variable that determines the sideways force

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    public float gravity = 50;


    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    void FixedUpdate() {

        if (joystick.Horizontal >= .5f) {
            horizontalMove = runSpeed;
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (joystick.Horizontal <= -.5f) {
            horizontalMove = -runSpeed;
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        float vertycalMove = joystick.Vertical;
        //Hop Jump 
        if (joystick.Vertical <= -.2f && rb.position.y < 2f) {
            rb.AddForce(0, jump, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (joystick.Vertical > -.2f){ 
        Time.timeScale = 0.3f;
        }
        else {

            Time.timeScale = 1;
        }

       /* if (vertycalMove <= -.5f) {
            crouch = true;
        }
        else {
            crouch = false;
        }
    */

        // Add a forward force
        
        if (Input.GetKey("d"))  // If the player is pressing the "d" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))  // If the player is pressing the "a" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("w") && rb.position.y < 2f) {
            rb.AddForce(0, jump, 0 * Time.deltaTime, ForceMode.VelocityChange);
            
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }

        if (Input.GetKey("w")) {

            Time.timeScale = 0.3f;

        }

        else {

            Time.timeScale = 1;
        }

        if (Input.GetKey("q")) {

            transform.Rotate(new Vector3(0, 0, -80));

        }

        if (Input.GetKey("e")) {

            transform.Rotate(new Vector3(0, 0, 80));

        }

    }
    

    }







