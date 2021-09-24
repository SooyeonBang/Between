using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerwalking1 : MonoBehaviour

{
    //Player 포지션 
    public Transform playerTransform;

    public float speed;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    // Start is called before the first frame update
    void Start()
    {
        //Player 포지션을 가지고 온다 
        transform.position = playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            //화면의 X축의 최대점과 최소점을 넘지않게 설정
            float clampedX = Mathf.Clamp(playerTransform.position.x, minX, maxX);
            //화면의 Y축의 최대점과 최소점을 넘지않게 설정
            float clampedY = Mathf.Clamp(playerTransform.position.y, minY, maxY);

            //카메라를 clampedX,clampedY 방향으로 speed 속도를 부드럽게 이동
            transform.position = Vector3.Lerp(transform.position, new Vector3(clampedX, clampedY,-15), speed);
        }

    }
}