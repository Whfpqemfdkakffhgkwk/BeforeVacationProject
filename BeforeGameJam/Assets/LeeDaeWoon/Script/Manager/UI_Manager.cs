using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Inst { get; private set; }
    void Awake() => Inst = this;

    public float Coin_Number;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
