using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * Player.Instance.speed;
    }
}
