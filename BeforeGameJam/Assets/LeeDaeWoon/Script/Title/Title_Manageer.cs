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

    #region ���� ��ư
    public void Start_Click()
    {
        BtnDirector_Open();
        Debug.Log("����");
    }
    #endregion

    #region ���� ��ư
    public void Setting_Click()
    {
        BtnDirector_Open();
        Debug.Log("����");
    }
    #endregion

    #region �������� ��ư
    public void Exit_Click()
    {
        BtnDirector_Open();
        ExitWindow_Open();
    }

    public void Exit_Yes() => Application.Quit();

    public void Exit_No()
    {
        ExitWindow_Close();
        BtnDirector_Close();
    }

    void ExitWindow_Close() => Exit_Window.transform.DOScale(new Vector3(0, 0, 0), 1f).SetEase(Ease.OutBack);
    void ExitWindow_Open() => Exit_Window.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
    #endregion

    #region ��ư ����
    void BtnDirector_Open()
    {
        Start_Btn.transform.DOLocalMoveX(-1900, 1).SetEase(Ease.OutCirc);
        Setting_Btn.transform.DOLocalMoveX(1900, 1).SetEase(Ease.OutCirc);
        Exit_Btn.transform.DOLocalMoveX(-1900, 1).SetEase(Ease.OutCirc);
    }

    void BtnDirector_Close()
    {
        Start_Btn.transform.DOLocalMoveX(0, 1).SetEase(Ease.OutCirc);
        Setting_Btn.transform.DOLocalMoveX(0, 1).SetEase(Ease.OutCirc);
        Exit_Btn.transform.DOLocalMoveX(0, 1).SetEase(Ease.OutCirc);
    }
    #endregion
}
