using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float coin;

    public float Coin_increase; // ���� ���� ������
    public float TimeLimit; // ���� ���ѽð�
    public float Bigger_Time; // ���� �Ŵ�ȭ ���� �ð�

    public bool Bigger_Appearance = false; // �Ŵ�ȭ ���� ����

    [Header("���׷��̵�")]
    public float Coin_Upgrade;
    public float TimeLimit_Upgrade;
    public float Bigger_Upgrade;

    private void Start()
    {
        if (Instance != this)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
            coin += 1000;
    }
}
