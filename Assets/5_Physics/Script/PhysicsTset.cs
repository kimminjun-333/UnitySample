using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTset : MonoBehaviour
{

    //�� ��ũ��Ʈ�� �޷��ִ� ��ü�� �����̰� ������
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

        //���� ������ �Ͼ�� �������� Update���� �̵��� ��ġ�� ������ �Ͼ��
        //���� �������� ���� Rigdbody�� ���� ����
        //transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * moveSpeed);
        rb.MovePosition(rb.position + (new Vector3(x, 0, z) * Time.deltaTime * moveSpeed));
        if (Input.GetButtonDown("Jump"))
        {
            //rb.velocity = �����̴���
            //rb.angularVelocity = ȸ���ϴ� ��
            //rb.velocity = Vector3.up * JumpPower;//������ �Ʒ��Լ� �����ϰ� ��ĵ��
            //transform.Translate(Vector3.up);
            rb.AddForce(Vector3.up * JumpPower,ForceMode.VelocityChange);
            //ForceMode.VelocityChange �� ������ ������ �Ʒ��Լ� ���þ���

            //���� ���Ҷ� AddForce �Լ��� ���
            //ForceMode
            //                  �߷� ����           �߷� ����
            //���ӵ� �߰�       .Force              .Acceleration
            //��� �߰�       .Impulse            .VelocityChange 

            //rb.AddTorque();//ȸ��
            //rb.angularVelocity//ȸ�� ���
            //rb.maxAngularVelocity//�ִ� ȸ�� ����� ����
            //rb.maxLinearVelocity //�ִ� ���� ����� ����
            //rb.drag //(����)���� (������)
            //rb.angularDrag //ȸ�� ����

        }

        //Physics.Raycast
        if(Input.GetButtonDown("Fire1"))//����(x+��) �߻�(���������Ʈ ����)
        {
            //���� (+z�� ����)�� �ִ� �ݶ��̴��� �����ؼ� ���� Enemy�±װ� ������ ���ְ� ����

            Ray ray = new Ray(transform.position, Vector3.forward);
            Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 0.2f);
            //                        ����ǥ�ðŸ�         ���̻���
            if (Physics.Raycast(ray, out RaycastHit hit
                , 10, 1 << LayerMask.NameToLayer("Default")))
            {
                print($"�ݶ��̴� ���� �� : {hit.collider}");//out Ű�������ؼ� ����� ��������
                if (hit.collider.CompareTag("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }

            //if(Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hit 
            //    ,10, 1<<LayerMask.NameToLayer("Default")))
            //{
            //    print($"�ݶ��̴� ���� �� : {hit.collider}");//out Ű�������ؼ� ����� ��������
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
            //Enemy �±׸� ���� ������Ʈ�� �浹�ϸ� -z �������� ƨ�ܳ����� �ʹ�
            rb.AddForce(Vector3.back * 50f, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //����
        //InputManager�� ���� �Է� ��� �Ϸ��� �Ұ��
        //��� �Է� ó���� Update���� �̷������ ������
        //FixedUpdate ��Ȯ�� ������ �˱� �����
        //if(Input.GetButtonDown("Jump"))
        //{
        //    transform.Translate(Vector3.up);
        //}

        //transform.Translate(new Vector3(x, 0, z) * Time.deltaTime * moveSpeed);
    }

}
