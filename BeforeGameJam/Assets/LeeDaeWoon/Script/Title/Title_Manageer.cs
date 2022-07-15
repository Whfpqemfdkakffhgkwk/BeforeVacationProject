using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Title_Manageer : MonoBehaviour
{
    [Header("Ÿ��Ʋ �ΰ�")]
    [SerializeField] GameObject TItle_Logo;

    [Header("��ư")]
    [SerializeField] GameObject Exit_Btn;
    [SerializeField] GameObject Start_Btn;
    [SerializeField] GameObject Setting_Btn;

    [Header("â")]
    [SerializeField] GameObject Exit_Window;
    [SerializeField] GameObject Start_Window;
    [SerializeField] GameObject Setting_Window;

    void Start()
    {
        Logo_Director();
    }

    void Update()
    {

    }

    void Logo_Director() => TItle_Logo.transform.DOLocalMoveY(341f, 1f).SetEase(Ease.OutBounce);

    public void Start_Click()
    {
        Btn_Director();
        Debug.Log("����");
    }

    public void Setting_Click()
    {
        Btn_Director();
        Debug.Log("����");
    }

    public void Exit_Click()
    {
        Btn_Director();
        ExitWindow();
        //Application.Quit();
    }

    void Btn_Director()
    {
        Start_Btn.transform.DOLocalMoveX(-1900, 1).SetEase(Ease.OutCirc);
        Setting_Btn.transform.DOLocalMoveX(1900, 1).SetEase(Ease.OutCirc);
        Exit_Btn.transform.DOLocalMoveX(-1900, 1).SetEase(Ease.OutCirc);
    }

    #region â ����
    void ExitWindow() => Exit_Window.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
    #endregion
}
