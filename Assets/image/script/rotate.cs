using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{ 
    public float speed;

    void Update()
    {
    // transform.Rotate(new Vector3(0, 1, 0) * 180 * Time.deltaTime);
        transform.Rotate(new Vector3(10f, 20f, 30f) * speed * Time.deltaTime); // 절대 좌표 기준으로 회전
        transform.Rotate(new Vector3(10f, 20f, 30f) * speed * Time.deltaTime, Space.World);

    }
}
