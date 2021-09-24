using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{

    public float speed = 4f;

    private Rigidbody rd;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        rd = this.gameObject.GetComponent<Rigidbody>();

        move = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = speed * Time.deltaTime;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float j = Input.GetAxisRaw("Jump");

        // 이동거리 보정
        h = h * movespeed;
        v = v * movespeed;
        j = j * movespeed;

        // 실제 이동
        transform.Translate(Vector3.right * h);
        transform.Translate(Vector3.forward* v);
        transform.Translate(Vector3.up * j * 2f);

    }
}
