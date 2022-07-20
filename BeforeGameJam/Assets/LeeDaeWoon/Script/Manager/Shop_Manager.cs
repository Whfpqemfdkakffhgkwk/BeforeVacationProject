using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shop_Manager : MonoBehaviour
{
    public TextMeshProUGUI Upgrade_Text;

    string Ability_Name;

    void Start()
    {
    }

    void Update()
    {
        Upgrade_Value();
    }

    void Upgrade_Value()
    {
        if (GameManager.Instance.CoinClick_Check == true)
        {
            Upgrade_Text.text = Ability_Name + GameManager.Instance.Coin_increase + "    ▶    " + (GameManager.Instance.Coin_increase + 50);

        }

        if (GameManager.Instance.TimeLimitClick_Check == true)
            Upgrade_Text.text = Ability_Name + GameManager.Instance.TimeLimit + "    ▶    " + (GameManager.Instance.TimeLimit + 0.5f);

        if (GameManager.Instance.BiggerClick_Check == true)
        {
            if (GameManager.Instance.Bigger_Upgrade >= 1)
                Upgrade_Text.text = Ability_Name + GameManager.Instance.Bigger_Time + "    ▶    " + (GameManager.Instance.Bigger_Time + 1f);
            else
                Upgrade_Text.text = Ability_Name;
        }
    }

    public void Ability_CoinUp()
    {
        GameManager.Instance.CoinClick_Check = true;
        GameManager.Instance.BiggerClick_Check = false;
        GameManager.Instance.TimeLimitClick_Check = false;
        Ability_Name = "코인 획득증가 : ";
    }

    public void Ability_TimeLimit()
    {
        GameManager.Instance.CoinClick_Check = false;
        GameManager.Instance.BiggerClick_Check = false;
        GameManager.Instance.TimeLimitClick_Check = true;
        Ability_Name = "제한시간 증가 : ";
    }

    public void Ability_Bigger()
    {
        GameManager.Instance.CoinClick_Check = false;
        GameManager.Instance.BiggerClick_Check = true;
        GameManager.Instance.TimeLimitClick_Check = false;
        if (GameManager.Instance.Bigger_Upgrade >= 1)
            Ability_Name = "거대화 지속시간 증가 : ";
        else
            Ability_Name = "거대화 해금";
    }
}
