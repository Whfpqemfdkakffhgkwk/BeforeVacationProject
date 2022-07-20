using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float coin;

    public float Coin_increase; // ���� ���� ������
    public float TimeLimit; // ���� ���ѽð�
    public float Bigger_Time; // ���� �Ŵ�ȭ ���� �ð�

    [Header("����")]
    public float Coin_Upgrade;
    public float TimeLimit_Upgrade;
    public float Bigger_Upgrade;

    public bool CoinClick_Check = false;
    public bool TimeLimitClick_Check = false;
    public bool BiggerClick_Check = false;

    private void Start()
    {
        if (Instance != this)
            Destroy(gameObject);
        else
            DontDestroyOnLoad(gameObject);
    }
}
