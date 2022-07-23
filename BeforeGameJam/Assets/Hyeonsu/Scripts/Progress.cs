using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progress : MonoBehaviour
{
    Slider slider;
    [SerializeField] GameObject MaxObj;
    private float maxDis;
    private float nowDis;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        nowDis = Player.Instance.transform.position.x;
        maxDis = MaxObj.transform.position.x;
        //slider.maxValue = maxDis;
        slider.value = nowDis / maxDis;
        Debug.Log(nowDis / maxDis);
    }
}
