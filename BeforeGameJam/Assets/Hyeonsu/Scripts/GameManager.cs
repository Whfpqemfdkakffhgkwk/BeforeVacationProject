using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public float coin;

    public float Coin_increase; // 현재 코인 증가량
    public float TimeLimit; // 현재 제한시간
    public float Bigger_Time; // 현재 거대화 지속 시간

    public bool Bigger_Appearance = false; // 거대화 출현 가능

    [Header("업그레이드")]
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
