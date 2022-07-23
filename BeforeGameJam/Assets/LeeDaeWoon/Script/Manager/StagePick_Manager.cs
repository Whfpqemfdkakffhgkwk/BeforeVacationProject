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

    void Start()
    {

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

    public void MenuOpen()
    {

    }
}
