using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    private int jumpCount = 2;
    public float speed;
    private bool SlideWhileJumping;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        #region Ű�Է� �޴� �ڵ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.M) && jumpCount == 2)
        {
            Sliding();
        }
        else if (Input.GetKeyUp(KeyCode.M) && jumpCount == 2)
        {
            SlidingRise();
        }
        #endregion
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject coll = collision.gameObject;
        switch (coll.tag)
        {
            case "Floor":
                jumpCount = 2;
                SlideWhileJumping = true;
                break;
            case "Obstacle":
                Hit(collision.gameObject);
                break;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Jelly"))
        {
            Destroy(collision.gameObject);
            speed += 0.2f;
        }
    }
    void Jump()
    {
        if (jumpCount > 0)
        {
            //�����ϸ� �����̵� ���
            SlidingRise();

            rb.velocity = new Vector2(0f, 0f);
            rb.AddForce(Vector2.up * 1000);
            jumpCount--;
        }
    }
    //�����̵�
    void Sliding()
    {
        if (SlideWhileJumping)
        {
            transform.Rotate(0, 0, 90);
            transform.position -= new Vector3(0, 0.58f, 0);
            SlideWhileJumping = false;
        }
    }
    //�����̵� ������ �ٽ� ���ƿ���
    void SlidingRise()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        SlideWhileJumping = true;
    }
    //�浹 �Ͽ�����
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
    //�浹�� �ӵ� �پ��� ������ ���ִ� �ڷ�ƾ
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
