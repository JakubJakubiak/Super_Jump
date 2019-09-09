using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {


    public GameObject cube;

    public float trueTimer;
    float timer;

    public float minX, maxX, minY, maxY, minZ, maxZ;
   
    void Start () {
        timer = trueTimer;
    }

   
    void Update() {

        timer -= Time.deltaTime;
        if (timer <= 0) { 
        float x = Random.Range(minX, maxX);  // *--10. 10
        float y = Random.Range(minY, maxY);// 13, 17  z 100
        float z = Random.Range(minZ, maxZ);

            timer = trueTimer;
            Instantiate(cube, new Vector3(x, y, z), Quaternion.identity);
            
            
        }
       
    }

  
}
