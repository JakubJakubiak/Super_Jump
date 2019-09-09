using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     // A reference to our PlayerMovement script

    public int points;


	// This function runs when we hit another object.
	// We get information about the collision and call it "collisionInfo".
	void OnCollisionEnter (Collision collisionInfo)
	{
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "RuraSpwner")
        {
            Debug.Log("Punkt");

        }
       // Time.timeScale = 0.3f;
        

        if (collisionInfo.collider.tag == "Obstacle") 
		
		{
			movement.enabled = false;   // Disable the players movement.
			FindObjectOfType<GameManager>().EndGame();
            Time.timeScale = 0.3f;
        }
	}


    private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "RuraSpwner")
        {
            Debug.Log("Punkt");
            ++points;
        }

      

        
    }

}
