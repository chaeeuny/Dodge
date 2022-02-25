using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //생성한 탄알의 원본 프리팹
    public GameObject bulletprefet;

    //최소 생성 주기
    public float spawnRateMin = 0.5f;

    //최대 생성 주기
    public float spawnRateMax = 3f;

    // 최근 생성 시점에서 지나간 시간
    private float timeAfterSpawn;

    //실제 생성 주기기
    private float spawnRate;

    //발사할 대상
    private Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerController 컴포넌트를 가진 게임 오브젝트를 찾아서 그 오브젝트의 위치값을 가져와 
        Target = FindObjectOfType<PlayerController>().transform;

        //최근 생성 이후에 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;

        //실제 탄알 생성 간격을 spawnMin 과 spawn Max 사이에서 랜덤값 지정
        Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(bulletprefet);


    }
}
