using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createscenechanger : MonoBehaviour
{
    public GameObject[] prefabs; //찍어낼 게임 오브젝트를 넣어요
                                 //배열로 만든 이유는 게임 오브젝트를
                                 //다양하게 찍어내기 위해서 입니다
    private BoxCollider2D area;    //박스콜라이더의 사이즈를 가져오기 위함
    public int count = 30;      //찍어낼 게임 오브젝트 갯수

    private List<GameObject> gameObject = new List<GameObject>();

    void Start()
    {
        area = GetComponent<BoxCollider2D>();

        for (int i = 0; i < count; ++i)//count 수 만큼 생성한다
        {
            Spawn();//생성 + 스폰위치를 포함하는 함수
        }

        area.enabled = false;
    }
    //밑에 코드가 더 있습니다





    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);
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



}//스크립트 종료



