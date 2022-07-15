using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Title_Manageer : MonoBehaviour
{
    [SerializeField] GameObject TItle_Logo;

    void Start()
    {
        Logo_Director();
    }

    void Update()
    {

    }

    void Logo_Director() => TItle_Logo.transform.DOLocalMoveY(341f, 1f).SetEase(Ease.OutBounce);
}
