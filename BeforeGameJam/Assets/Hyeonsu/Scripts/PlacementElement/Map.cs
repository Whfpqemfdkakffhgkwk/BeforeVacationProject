using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    void Update()
    {
        string Type = gameObject.tag;
        switch (Type)
        {
            case "Map":
                transform.position += Vector3.left * Time.deltaTime * Player.Instance.speed;
                break;
            case "Background":
                transform.localPosition += Vector3.left * Time.deltaTime * (Player.Instance.speed / 3);
                //배경 반복 코드
                break;
            case "Floor":
                //바닥 반복 코드
                break;
        }
    }

}
