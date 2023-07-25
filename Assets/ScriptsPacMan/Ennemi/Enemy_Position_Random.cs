using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Position_Random : MonoBehaviour
{
    public Vector3[] positions = { new Vector3 { x = -6.86f, y = 0.531f, z = 7.42f },
                                   new Vector3 { x = -1.98f, y = 0.531f, z = 7.42f},
                                   new Vector3 { x = 17.33f, y = 0.531f, z = 7.42f}};


    // Start is called before the first frame update
    void Start()
    {
        // Get a random index from the array
        int randomIndex = Random.Range(0, positions.Length);

        // Get the position at the random index
        Vector3 randomPosition = positions[randomIndex];

        // Set the object's position to the random position, with the x-coordinate randomly offset by up to 1 unit
        transform.position = new Vector3(randomPosition.x, randomPosition.y, randomPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
