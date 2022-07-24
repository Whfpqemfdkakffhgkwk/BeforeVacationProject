using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class StagePick_Manager : MonoBehaviour
{
    [Header("스테이지 버튼")]
    public Image Stage_02;
    public Image Stage_03;
    public Image Stage_04;
    public Image Boss_Stage;

    [Header("메뉴")]
    public GameObject Menu;

    public Image Touch_Limit;
    public GameObject Setting_Window;
    private bool Open_Check;

    void Start()
    {
        Touch_Limit.raycastTarget = false;
    }

    void Update()
    {
        Stage_Unlocking_Color();
    }

    #region 스테이지 잠금해제

    public void Stage_Unlocking(int Stage_lock)
    {
        if (GameManager.Instance.Stage_Clear >= Stage_lock)
        {
            switch (Stage_lock)
            {
                case 0:
                    SceneManager.LoadScene("TestDevelop");
                    break;

                case 1:
                    Debug.Log("asdfasdf");
                    break;
            }
        }
    }

    public void Stage_Unlocking_Color()
    {
        switch (GameManager.Instance.Stage_Clear)
        {
            case 1:
                Stage_02.DOColor(Color.white, 0);
                break;

            case 2:
                Stage_03.DOColor(Color.white, 0);
                break;

            case 3:
                Stage_04.DOColor(Color.white, 0);
                break;

            case 4:
                Boss_Stage.DOColor(Color.white, 0);
                break;
        }
    }

    #endregion

    public void Menu_Click() => StartCoroutine(MenuOpen());
    public void Shop_Clikck() => SceneManager.LoadScene("Shop");

    #region 설정 버튼
    public void Setting_Click() => SettingWindow_Open();

    public void Setting_Close() => StartCoroutine(SettingWindow_Close());

    #region 창 연출
    IEnumerator SettingWindow_Close()
    {
        Setting_Window.transform.DOScale(new Vector3(0, 0, 0), 1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(1f);
        Touch_Limit.raycastTarget = false;
    }

    void SettingWindow_Open()
    {
        Touch_Limit.raycastTarget = true;
        Setting_Window.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
    }
    #endregion

    #endregion

    public IEnumerator MenuOpen()
    {
        if (Open_Check == false)
        {
            Menu.transform.DOLocalMoveX(372f, 1f).SetEase(Ease.InOutCubic);
            yield return new WaitForSeconds(1f);
            Open_Check = true;
        }

        else
        {
            Menu.transform.DOLocalMoveX(0f, 1f).SetEase(Ease.InOutCubic);
            yield return new WaitForSeconds(1f);
            Open_Check = false;
        }
    }
}
