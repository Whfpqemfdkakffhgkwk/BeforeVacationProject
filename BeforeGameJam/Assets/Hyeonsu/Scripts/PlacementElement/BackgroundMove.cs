using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    void Update()
    {
        transform.localPosition += Vector3.left * Time.deltaTime * (Player.Instance.speed / 3);
    }
}
