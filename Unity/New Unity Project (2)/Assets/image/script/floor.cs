using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Update()
    {
        Vector3 curPos = transform.position;
        Vector3 nextPos = Vector3.right * speed * Time.deltaTime;
        transform.position = curPos + nextPos;
    }

}

