using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵� �ӷ�
    float speed = 3f;

    // �� �ڽ��� ���� ����
    public GameObject my;

<<<<<<< HEAD
    private void Strat()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ�
        //playerRigidbody�� �Ҵ�
=======
    private void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // playerRigidbody�� �Ҵ�
>>>>>>> 6d3e1922c67b03fb3d625b4736d88bd1196a03c9
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
<<<<<<< HEAD
        //������� �������� �Է°��� �����ؼ� ����
        float xInput = Input.GetAxis("Horizontal");
        //Ű���� : 'A', -> : ���� ���� : �ִ� �� : -1.0f
        //Ű���� : 'D', <- : ���� ���� : �ִ� �� : +1.0f
        
        float zlnput = Input.GetAxis("Vertical");
        //Ű���� : 'W', ^ : ���� ���� : +1.0f
        //Ű���� : 'S', V : ���� ���� : -1.0f
       

    }


=======
        // ������� �������� �Է°��� �����ؼ� ����
        float xInput = Input.GetAxis("Horizontal");
        // Ű���� : 'A', <- : ���ǹ��� : -1.0f
        // Ű���� : 'D', -> : ���ǹ��� : +1.0f
        float zInput = Input.GetAxis("Vertical");
        // Ű���� : 'W', ^ : ���ǹ��� : +1.0f
        // Ű���� : 'S', �� : ���ǹ��� : -1.0f
    }

>>>>>>> 6d3e1922c67b03fb3d625b4736d88bd1196a03c9
    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
<<<<<<< HEAD
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.Space) == true)
        {
            playerRigidbody.AddForce(0f, speed, 0f);
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
=======
            // ���� ����Ű �Է��� ������ ���
            playerRigidbody
                .AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            // �Ʒ��� ����Ű �Է��� ������ ���
            // -z ���� �� �ֱ�
            playerRigidbody
                .AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            // ������ ����Ű �Է��� ������ ���
            // x ���� �� �ֱ�
            playerRigidbody
                .AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ���
            // -x ���� �� �ֱ�
            playerRigidbody
                .AddForce(-speed, 0f, 0f);
        }
>>>>>>> 6d3e1922c67b03fb3d625b4736d88bd1196a03c9
    }

    void Die()
    {
        my.SetActive(false);
    }
}
