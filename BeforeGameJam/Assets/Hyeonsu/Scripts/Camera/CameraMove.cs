using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private void Update()
    {
        transform.position = new Vector3(Player.Instance.transform.position.x + 8, 0, -10);
    }
}
