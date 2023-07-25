using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Follows : MonoBehaviour
{
    public Transform targetObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 2 * Time.deltaTime);
    }
}
