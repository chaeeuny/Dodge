using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //������ ź���� ���� ������
    public GameObject bulletprefet;

    //�ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;

    //�ִ� ���� �ֱ�
    public float spawnRateMax = 3f;

    // �ֱ� ���� �������� ������ �ð�
    private float timeAfterSpawn;

    //���� ���� �ֱ��
    private float spawnRate;

    //�߻��� ���
    private Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������ 
        Target = FindObjectOfType<PlayerController>().transform;

        //�ֱ� ���� ���Ŀ� ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;

        //���� ź�� ���� ������ spawnMin �� spawn Max ���̿��� ������ ����
        Random.Range(spawnRateMin, spawnRateMax);
    }

    // Update is called once per frame
    void Update()
    {

        Instantiate(bulletprefet);


    }
}
