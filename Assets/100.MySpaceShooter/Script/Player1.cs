using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

    public class Player1 : MonoBehaviour
    {

    public float moveSpeed = 20f;
    private Rigidbody2D rb;

    public GameObject missilePre;//미사일
    public float Attspeed = 1f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        StartCoroutine(Att(Attspeed));
    }
    public GameObject gameovermassage;
    void Update()
    {
        //Input : InputManager의 기능을 활용하여 입력 처리를 할 수 있는 클래스
        //Input.GetAxis() : 미리 정의되어있는 입력 축의 값을 가져옴
        //예 : Horizontal : x축, Vertical : y축 

        Move();

    }
    private IEnumerator Att(float Attspeed)
    {
        while (true)
        {
            yield return new WaitForSeconds(Attspeed);
            GameObject missile = Instantiate(missilePre, transform.position, transform.rotation);
        }
    }
    
    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + (new Vector2(x, y) * Time.deltaTime) * moveSpeed);

        //transform.Translate(new Vector3(x, y) * Time.deltaTime * moveSpeed);

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
           rb.AddForce(collision.contacts[0].normal * 5000f, ForceMode2D.Force);
        }
    }

    
    public void GameOver()
    {
        gameovermassage.SetActive(true);
        Time.timeScale = 0f;
    }
}

