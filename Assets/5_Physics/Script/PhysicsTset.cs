using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTset : MonoBehaviour
{

    //이 스크립트가 달려있는 물체를 움직이고 싶을때
    public float moveSpeed;
    public float JumpPower;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //물리 연산이 일어나는 시점에서 Update에서 이동한 위치와 간섭이 일어나면
        //다음 프레임의 값이 Rigdbody에 의해 변함
        //transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * moveSpeed);
        rb.MovePosition(rb.position + (new Vector3(x, 0, z) * Time.deltaTime * moveSpeed));
        if (Input.GetButtonDown("Jump"))
        {
            //rb.velocity = 움직이는힘
            //rb.angularVelocity = 회전하는 힘
            //rb.velocity = Vector3.up * JumpPower;//점프시 아래함수 무시하고 점캔됨
            //transform.Translate(Vector3.up);
            rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
            //ForceMode.VelocityChange 를 넣으면 점프시 아래함수 무시안함

            //힘을 가할때 AddForce 함수를 사용
            //ForceMode
            //                  중량 적용           중량 무시
            //가속도 추가       .Force              .Acceleration
            //운동량 추가       .Impulse            .VelocityChange 

            //rb.AddTorque();//회전
            //rb.angularVelocity//회전 운동량
            //rb.maxAngularVelocity//최대 회전 운동량을 제한
            //rb.maxLinearVelocity //최대 직선 운동량을 제한
            //rb.drag //(공기)저항 (마찰값)
            //rb.angularDrag //회전 저항

        }

        //Physics.Raycast
        if(Input.GetButtonDown("Fire1"))//전방(x+축) 발사(전방오브젝트 감지)
        {
            //전방 (+z축 방향)에 있는 콜라이더를 감지해서 만약 Enemy태그가 있으면 없애고 싶음

            Ray ray = new Ray(transform.position, Vector3.forward);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 0.2f);
            //                        레이표시거리         레이색깔
            if (Physics.Raycast(ray, out RaycastHit hit
                , 10, 1 << LayerMask.NameToLayer("Default")))
            {
                print($"콜라이더 감지 됨 : {hit.collider}");//out 키워드사용해서 결과값 가져오기
                if (hit.collider.CompareTag("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }

            //if(Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hit 
            //    ,10, 1<<LayerMask.NameToLayer("Default")))
            //{
            //    print($"콜라이더 감지 됨 : {hit.collider}");//out 키워드사용해서 결과값 가져오기
            //    if(hit.collider.CompareTag("Enemy"))
            //    {
            //        Destroy(hit.collider.gameObject );
            //    }
            //}


        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            //Enemy 태그를 가진 오브젝트와 충돌하면 -z 방향으로 튕겨나가고 싶다
            rb.AddForce(Vector3.back * 50f, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //점프
        //InputManager를 통한 입력 제어를 하려고 할경우
        //모든 입력 처리는 Update에서 이루어지기 때문에
        //FixedUpdate 정확한 시점을 알기 어려움
        //if(Input.GetButtonDown("Jump"))
        //{
        //    transform.Translate(Vector3.up);
        //}

        //transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * moveSpeed);
    }

}
