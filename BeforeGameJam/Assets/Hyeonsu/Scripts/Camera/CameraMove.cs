using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void Update()
    {
        transform.position = new Vector3(Player.transform.position.x + 5, 0, -10);
    }
}
