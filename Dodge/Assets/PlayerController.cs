using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵� �ӷ�
    public float speed = 8f;

    // �� �ڽ��� ���� ����
    public GameObject my;

    private void Strat()
    {
        //���� ������Ʈ���� Rigidbody ������Ʈ�� ã�Ƽ�
        //playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //������� �������� �Է°��� �����ؼ� ����

        float xInput = Input.GetAxis("Horizontal");
        //Ű���� : 'A', -> : ���� ���� : �ִ� �� : -1.0f
        //Ű���� : 'D', <- : ���� ���� : �ִ� �� : +1.0f
        
        float zlnput = Input.GetAxis("Vertical");
        //Ű���� : 'W', ^ : ���� ���� : +1.0f
        //Ű���� : 'S', V : ���� ���� : -1.0f

        float xSpeed = xInput * speed;
        float zSpeed = zlnput * speed;
        //���� �Է°��� �̵��ӷ��� ����� ����

        //vecter3 �ӵ��� xSpeed 
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        //������ٵ� �ӵ��� newvelocity �� �Ҵ�
        playerRigidbody.velocity = newVelocity;


    }


    void DirectInput()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
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

    public void Die()
    {
        gameObject.SetActive(false);
    }

    void Sum()
    {
    }
}
