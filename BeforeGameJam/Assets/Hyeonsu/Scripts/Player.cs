using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    private int jumpCount = 2;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        //앞으로 움직이는 코드
        transform.position += Vector3.right * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject coll = collision.gameObject;
        switch(coll.tag)
        {
            case "Floor":
                jumpCount = 2;
                break;
            case "Enemy":
                //transform.DO
                break;
        }
    }
    void Jump()
    {
        if(jumpCount > 0)
        {
            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(Vector2.up * 1000);
            jumpCount--;
        }
    }
}
