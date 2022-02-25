using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletrigidbody;

    //ź���̵��ӷ�
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletrigidbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵��ӷ�
        bulletrigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);

    }

    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼ҵ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ��������?
        if (other.tag == "Player");
        {//���� (�浹��) ���� ������Ʈ���� PlyerController ������Ʈ�� ��������
            PlayerController playerController = other.GetComponent<PlayerController>();

            //�������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�

            if (playerController != null)
            {
                //PlayerController ������Ʈ�� Die() �޼ҵ� ����
                playerController.Die();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
