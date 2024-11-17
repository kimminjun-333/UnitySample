using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMasseageTest : MonoBehaviour
{
    //Collider ������Ʈ�� IsTrigger �Ӽ��� true�� ������ ������
    //�������� �浹�� ����Ű�� �ʴ� ��� Collider ���� ���� �ٸ� Collider�� ��ȣ�ۿ� ����
    //OnCollisionXX �޼��� �Լ��� ���������� �� ��ü�� �ϳ��� �ݵ�� Rigidbody ������Ʈ�� �־�� ��
    //Trigger �޽��� �Լ��� �浹 ������ �������� �����Ƿ� ���� ȿ�����̴�

    //1. OnTriggerEnter
    private void OnTriggerEnter(Collider other)
    {
        print($"Ʈ���ſ� ���� ȣ�� ��ü : {name}, ��� : {other.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        print($"Ʈ���ſ��� ���� ȣ�� ��ü : {name}, ��� : {other.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        print($"Ʈ���ſ� ü���� ȣ�� ��ü : {name}, ��� : {other.name}");
    }

}
