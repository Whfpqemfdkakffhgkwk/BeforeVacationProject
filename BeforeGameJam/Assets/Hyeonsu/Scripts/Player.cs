using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    private int jumpCount = 2;
    public float speed;
    private bool check;
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
        if(Input.GetKeyDown(KeyCode.M) && jumpCount == 2)
        {

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject coll = collision.gameObject;
        switch (coll.tag)
        {
            case "Floor":
                jumpCount = 2;
                break;
            case "Obstacle":
                Hit(collision.gameObject);
                break;
        }
    }
    void Jump()
    {
        if (jumpCount > 0)
        {
            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(Vector2.up * 1000);
            jumpCount--;
        }
    }
    void Sliding()
    {

    }
    void Hit(GameObject CollObj)
    {
        if (jumpCount == 2)
        {
            rb.AddExplosionForce(300f, CollObj.transform.position, 300f, 10f);
            StartCoroutine(SpeedDown());
        }
        else
        {
            rb.AddExplosionForce(300f, CollObj.transform.position, 300f);
            StartCoroutine(SpeedDown());

        }

    }

    IEnumerator SpeedDown()
    {
        speed = 1;
        while (true)
        {
            speed += Time.deltaTime;
            yield return null;
            if (speed >= 5)
            {
                speed = 5;
                break;
            }
        }
    }
}
