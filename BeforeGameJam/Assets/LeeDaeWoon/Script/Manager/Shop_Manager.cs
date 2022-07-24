using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Shop_Manager : MonoBehaviour
{
    public enum Ability
    {
        CoinUP,
        TimeLimit,
        Bigger,
        None
    }
    public Ability ability;

    public TextMeshProUGUI Bigger_Text;

    [Header("�ɷ� ����")]
    public string Ability_Name;
    public TextMeshProUGUI Price;
    public TextMeshProUGUI Level;

    public TextMeshProUGUI Upgrade_Text;

    public GameObject Upgrade_Btn;

    [Header("�����ݾ�")]
    public TextMeshProUGUI Money;


    void Start()
    {
        ability = Ability.None;
    }

    void Update()
    {
        Ability_Value();
        Money.text = "�� : " + GameManager.Instance.coin;
    }

    public void Upgrade_Click()
    {
        float Coin = GameManager.Instance.coin;

        float Coin_Upgrade = GameManager.Instance.Coin_Upgrade;
        float TimeLimit_Upgrade = GameManager.Instance.TimeLimit_Upgrade;
        float Bigger_Upgrade = GameManager.Instance.Bigger_Upgrade;

        switch (ability)
        {
            case Ability.CoinUP:
                if (Coin >= Coin_Upgrade * 300 && Coin_Upgrade < 20)
                {
                    GameManager.Instance.coin -= GameManager.Instance.Coin_Upgrade * 300;
                    GameManager.Instance.Coin_increase += 50;
                    GameManager.Instance.Coin_Upgrade += 1;
                }
                break;

            case Ability.TimeLimit:
                if (Coin >= TimeLimit_Upgrade * 150 && TimeLimit_Upgrade < 20)
                {
                    GameManager.Instance.coin -= GameManager.Instance.TimeLimit_Upgrade * 300;
                    GameManager.Instance.TimeLimit += 0.5f;
                    GameManager.Instance.TimeLimit_Upgrade++;
                }
                break;

            case Ability.Bigger:
                if (Bigger_Upgrade >= 1)
                {
                    if (Coin >= Bigger_Upgrade * 1000 && Bigger_Upgrade < 5)
                    {
                        GameManager.Instance.coin -= GameManager.Instance.Bigger_Upgrade * 300;
                        GameManager.Instance.Bigger_Time += 0.5f;
                        GameManager.Instance.Bigger_Upgrade++;
                    }
                }

                else
                {
                    if (Coin >= 5000)
                    {
                        GameManager.Instance.coin -= 5000;
                        GameManager.Instance.Bigger_Upgrade++;
                        GameManager.Instance.Bigger_Appearance = true;
                    }
                }
                break;
        }
    }

    public void Back_Click() => SceneManager.LoadScene("Stage_Pick");

    #region �ɷ� ����

    void Ability_Value()
    {
        switch (ability)
        {
            case Ability.CoinUP:
                if (GameManager.Instance.Coin_Upgrade < 20)
                {
                    Upgrade_Text.text = Ability_Name + GameManager.Instance.Coin_increase + "    ��    " + (GameManager.Instance.Coin_increase + 50);
                    Price.text = "�� : " + (300 * GameManager.Instance.Coin_Upgrade).ToString();
                    Level.text = "���� : " + GameManager.Instance.Coin_Upgrade;
                    Upgrade_Btn.SetActive(true);
                }

                else if (GameManager.Instance.Coin_Upgrade == 20)
                {
                    Upgrade_Text.text = Ability_Name + GameManager.Instance.Coin_increase;
                    Price.text = "�� : Max";
                    Level.text = "���� : Max";
                    Upgrade_Btn.SetActive(false);
                }

                break;

            case Ability.TimeLimit:
                if (GameManager.Instance.TimeLimit_Upgrade < 20)
                {
                    Upgrade_Text.text = Ability_Name + GameManager.Instance.TimeLimit + "    ��    " + (GameManager.Instance.TimeLimit + 0.5f);
                    Price.text = "�� : " + (150 * GameManager.Instance.TimeLimit_Upgrade).ToString();
                    Level.text = "���� : " + GameManager.Instance.TimeLimit_Upgrade;
                    Upgrade_Btn.SetActive(true);
                }

                else if (GameManager.Instance.TimeLimit_Upgrade == 20)
                {
                    Upgrade_Text.text = Ability_Name + GameManager.Instance.TimeLimit;
                    Price.text = "�� : Max";
                    Level.text = "���� : Max";
                    Upgrade_Btn.SetActive(false);
                }
                break;

            case Ability.Bigger:
                if (GameManager.Instance.Bigger_Upgrade >= 1)
                {
                    if (GameManager.Instance.Bigger_Upgrade < 5)
                    {
                        Upgrade_Text.text = "�Ŵ�ȭ ���ӽð� ���� : " + GameManager.Instance.Bigger_Time + "    ��    " + (GameManager.Instance.Bigger_Time + 1f);
                        Bigger_Text.text = "�Ŵ�ȭ ���ӽð� ����";
                        Price.text = "�� : " + (1000 * GameManager.Instance.Bigger_Upgrade).ToString();
                        Level.text = "���� : " + GameManager.Instance.Bigger_Upgrade;
                        Upgrade_Btn.SetActive(true);
                    }

                    else if (GameManager.Instance.Bigger_Upgrade == 5)
                    {
                        Upgrade_Text.text = "�Ŵ�ȭ ���ӽð� ���� : " + GameManager.Instance.Bigger_Time;
                        Price.text = "�� : Max";
                        Level.text = "���� : Max";
                        Upgrade_Btn.SetActive(false);
                    }
                }
                else
                {
                    Upgrade_Text.text = Ability_Name;
                    Price.text = "�� : 5000";
                    Level.text = "";
                    Upgrade_Btn.SetActive(true);
                }
                break;

            case Ability.None:
                Price.text = "";
                Level.text = "";
                Upgrade_Text.text = "";
                Upgrade_Btn.SetActive(false);
                break;
        }
    }

    #endregion

    #region �ɷ� Ŭ��

    public void Ability_CoinUp()
    {
        ability = Ability.CoinUP;
        Ability_Name = "���� ȹ������ : ";
    }

    public void Ability_TimeLimit()
    {
        ability = Ability.TimeLimit;
        Ability_Name = "���ѽð� ���� : ";
    }

    public void Ability_Bigger()
    {
        ability = Ability.Bigger;
        Ability_Name = "�Ŵ�ȭ �ر�";
    }

    #endregion
}
