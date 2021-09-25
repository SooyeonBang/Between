using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.up * speed * Time.deltaTime;
        transform.position = curPos + nextPos;
    }

}

