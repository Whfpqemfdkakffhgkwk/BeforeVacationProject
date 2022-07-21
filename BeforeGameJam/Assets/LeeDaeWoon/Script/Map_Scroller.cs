using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Scroller : MonoBehaviour
{
    public Transform Target;
    public float ScrollRange;
    public float Move_Speed;
    public Vector3 Move_Direction = Vector3.left;

    void Start()
    {
        
    }

    void Update()
    {
        Map_Move();
    }

    private void Map_Move()
    {
        transform.position += Move_Direction * Move_Speed * Time.deltaTime;
        if (transform.position.y <= -ScrollRange)
            transform.position = Target.position + Vector3.right * ScrollRange;
    }
}
