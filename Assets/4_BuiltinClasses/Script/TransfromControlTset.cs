using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransfromControlTset : MonoBehaviour
{
    public Transform target;

    //�⺻������ Transfrom�� position, rotation, localScale ������Ƽ������
    //�ش� ������Ʈ�� ��ġ, ����, ũ����� ������ �� �ִ�

    private void Start()
    {
        //ControlByDirection();
        //ControlStraightly();
        //ControlByMethod();

    }

    //���� ���� �����Ͽ� Transfrom�� ����
    private void ControlStraightly()
    {
        //���� ���� �����Ͽ� Transtfrom�� ����
        transform.position = new Vector3(3, 2, 1);
        //transform.rotation = new Quaternion(0.3f, 0.02f, 0.001f, 0);
        transform.rotation = Quaternion.Euler(30, 20, 10);//�̷����ϸ� 360�� ������ ��������
        print(transform.rotation);
        transform.localScale = new Vector3(4, 5, 6);
    }

    //���� (��,��,��,��,��,��)�� ���⺤�͸� �����Ͽ� Rotation ����
    private void ControlByDirection()
    {
        Vector3 lookDir = target.position - transform.forward;
        //����ġ���� target ��ġ�� �̵��ϱ� ���� ���ؾ��ϴ� ���� ���͸� ����

        //transform.up = target.position - transform.position;//�����ġ - ����ġ = up���⺤��

        //�ش� ������ ���� right�� �Ƿ���?
        //transform.right = target.position - transform.position;
        //transform.right = lookDir;
        //�ش� ������ ���� forward�� �Ƿ���
        //transform.forward = target.position - transform.position;
        //transform.right = lookDir;
        //�ش� ������ ���� down�� �Ƿ���
        //transform.up = -lookDir;
        //�ش� ������ ���� left�� �Ƿ���
        //transform.right = -lookDir;
        //�ش� ������ ���� backwrd�� �Ƿ���
        //transform.right = -lookDir;

    }

    private void ControlByMethod()
    {
        //Translate : Position�� �����ϴ� �Լ�
        transform.Translate(5, 0, 0);
        //Rotate : Totation�� �����ϴ� �Լ�
        transform.Rotate(30, 0, 0);

        
    }
    //Translate, Rotate �Լ��� ����Ͽ� �����ϴ� ���� : ControlByMethod()
    //transfrom.position, rotation �� ���� ���� �Ҵ��ϴ� �Ͱ� �����ڸ� : ControlStraightly()
    //���� position, rotation �������� ������� ������ �̷�����°����� �����ϸ� �ȴ�



    private void Update()
    {
        //Vector3 lookDir = target.position - transform.forward;
        //transform.up = lookDir; //�ǽð����� ȭ�鵹�ư�

        //transform.position = transform.position + new Vector3(3, 2, 1) * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
        //    new Vector3(30, 20, 10) * Time.deltaTime);
        
        transform.Translate(new Vector3(3, 2, 1) * Time.deltaTime);
        transform.Rotate(new Vector3(30, 20, 10) * Time.deltaTime);
        
    }

}
