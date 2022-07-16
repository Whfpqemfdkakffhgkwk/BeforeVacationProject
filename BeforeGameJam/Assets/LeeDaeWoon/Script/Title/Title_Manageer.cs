using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class Title_Manageer : MonoBehaviour
{
    [Header("타이틀 로고")]
    [SerializeField] GameObject TItle_Logo;

    [Header("UI")]
    [SerializeField] Image Touch_Limit;

    [Space(10)]
    [SerializeField] GameObject Exit_Btn;
    [SerializeField] GameObject Exit_Window;

    [Space(10)]
    [SerializeField] GameObject Start_Btn;
    [SerializeField] GameObject Start_Window;

    [Space(10)]
    [SerializeField] GameObject Setting_Btn;
    [SerializeField] GameObject Setting_Window;

    [Header("캐릭터")]
    [SerializeField] GameObject Character;

    void Start()
    {
        Logo_Director();
        Character_Move();
        Touch_Limit.raycastTarget = false;
    }

    void Update()
    {

    }

    void Logo_Director() => TItle_Logo.transform.DOLocalMoveY(341f, 1f).SetEase(Ease.OutBounce);
    void Character_Move() => Character.transform.DOLocalMoveX(-1040f, 2f);

    #region 시작 버튼

    public void Start_Click()
    {
        DOTween.PauseAll();
        SceneManager.LoadScene("Stage_Pick");
    }

    #endregion

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

    #region 게임종료
    public void Exit_Click() => ExitWindow_Open();

    public void Exit_Yes() => Application.Quit();

    public void Exit_No() => StartCoroutine(ExitWindow_Close());

    #region 창 연출
    IEnumerator ExitWindow_Close()
    {
        Exit_Window.transform.DOScale(new Vector3(0, 0, 0), 1f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(1f);
        Touch_Limit.raycastTarget = false;
    }

    void ExitWindow_Open()
    {
        Touch_Limit.raycastTarget = true;
        Exit_Window.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
    }
    #endregion

    #endregion
}
