using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Inst { get; private set; }
    void Awake() => Inst = this;

    public float Coin_Number;
    public TextMeshProUGUI Coin_Num_Text;

    void Start()
    {
        
    }

    void Update()
    {
        Coin_Num_Text.text = (Coin_Number * GameManager.Instance.Coin_increase).ToString();
    }
}
