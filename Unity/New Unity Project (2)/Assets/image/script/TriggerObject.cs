using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    public GameObject prefab;
    private BoxCollider2D area;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D o)
    {    //trigger와 충돌을 시작했을때 단 한번만 실행되는 함수
        print(o.gameObject.name);
        area = GetComponent<BoxCollider2D>();

        Spawn();

    }

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        Vector3 size = area.size;

        float posX = basePosition.x + Random.Range(3 * size.x / 2f, size.x * 2f);
        float posY = basePosition.y + Random.Range(-3 * size.y / 2f, 3 * size.y / 2f);
        float posZ = basePosition.z;

        Vector3 spawnPos = new Vector3(posX, posY, posZ);

        return spawnPos;
    }

    private void Spawn()
    {

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
