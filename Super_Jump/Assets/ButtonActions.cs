using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour {
    public Rigidbody rb;
    public float sidewaysForce = 500f;
    public float jump = 2f;
    public GameObject breaklight;

    public float forwardForce = 200000f;




    public void onPress() {
        breaklight.SetActive(true);


    }

    public void onRelease() {
        breaklight.SetActive(false);
    }



    public void ButtonJump() {


        // rb.AddForce(0, forwardForce * Time.deltaTime, 0);

        if (breaklight) { 
        rb.AddForce(0, forwardForce * Time.deltaTime, 0);
        Debug.Log("skok");
        }

    }
    public void ButtonLeft() {
        Debug.Log("lewo");
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);




    }
    public void ButtonRight() {
        Debug.Log("prawo");
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);



    }
   





}
