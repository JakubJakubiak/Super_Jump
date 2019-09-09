using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

    static public int points;
    private float secondDelay = 1;

    void Start() {
      
    }

    // Update is called once per frame
    void Update () {

        scoreText.text = "" + FindObjectOfType<PlayerCollision>().points;

    /*    this.gameObject.GetComponent<TextMesh>().text = points.ToString();
        secondDelay -= Time.deltaTime;
        if (secondDelay <= 0) {
            points += 1;
            secondDelay = 1;
        } 
*/

        // scoreText.text = player.position.z.ToString("0");
    }
}
