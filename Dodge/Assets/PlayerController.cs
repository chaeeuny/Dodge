using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동에 사용할 리지드바디 컴포넌트
    public Rigidbody playerRigidbody;
    // 이동 속력
    public float speed = 8f;

    // 내 자신을 담을 변수
    public GameObject my;

    private void Strat()
    {
        //게임 오브젝트에서 Rigidbody 컴포넌트를 찾아서
        //playerRigidbody에 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //수평축과 수직축의 입력값을 감지해서 저장
        float xInput = Input.GetAxis("Horizontal");
        //키보드 : 'A', -> : 음의 방향 : 최대 값 : -1.0f
        //키보드 : 'D', <- : 양의 방향 : 최대 값 : +1.0f
        
        float zlnput = Input.GetAxis("Vertical");
        //키보드 : 'W', ^ : 양의 방향 : +1.0f
        //키보드 : 'S', V : 음의 방향 : -1.0f
       

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

    void Die()
    {
        gameObject.SetActive(false);
    }

    void Sum()
    {
    }
}
