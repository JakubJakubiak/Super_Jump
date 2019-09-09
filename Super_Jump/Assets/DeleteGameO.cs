using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteGameO : MonoBehaviour {


    public float z = -20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (transform.position.z < z)
        {
            Destroy(gameObject);
        }
       
	}
}
