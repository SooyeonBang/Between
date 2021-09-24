using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public GameObject[] prefabs; //찍어낼 게임 오브젝트를 넣어요
                                 //배열로 만든 이유는 게임 오브젝트를
                                 //다양하게 찍어내기 위해서 입니다
                                 //박스콜라이더의 사이즈를 가져오기 위함//찍어낼 게임 오브젝트 갯수
    private BoxCollider2D area;

    private List<GameObject> gameObject = new List<GameObject>();

    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        area = GetComponent<BoxCollider2D>();

        //print(other.gameObject.name);
        Spawn();

    }

    /*void OnTriggerEnter2D(Collider2D o){    //trigger와 충돌을 시작했을때 단 한번만 실행되는 함수
        
    }*/

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(7 * size.x / 2f, size.x * 4f);
        float posY = basePosition.y + Random.Range(-3 * size.y / 2f, 3 * size.y / 2f);
        float posZ = basePosition.z;

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }

}
