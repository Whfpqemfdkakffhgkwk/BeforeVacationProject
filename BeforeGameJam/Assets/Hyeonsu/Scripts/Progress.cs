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
        maxDis = MaxObj.transform.position.x - Player.Instance.transform.position.x;
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        nowDis = MaxObj.transform.position.x - Player.Instance.transform.position.x;
        slider.value = 1 - (nowDis / maxDis);
    }
}
