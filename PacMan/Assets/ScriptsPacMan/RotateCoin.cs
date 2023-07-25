using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int rotateSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
    }
}
