using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMessageTest : MonoBehaviour
{
    //�������� �浹 �Ǵ� ��ȣ�ۿ뿡 ���ؼ� ȣ��Ǵ� �޼���
    //OnCollisionXX �޽��� ȣ�� ���� : ȣ�� �� ������Ʈ�� Collider ������Ʈ�� �����ؾ� �ϸ�
    //**�޽��� �Լ��� ȣ���ϴ� ��ü�� Rigidbody�̹Ƿ�, �浹�� �� ������Ʈ�� �ϳ����� �� Rigidbdy�� �پ� �־�� ȣ��ȴ�


    //1. OnCollisionEnter : �������� �浹�� �Ͼ���� ȣ��
    private void OnCollisionEnter(Collision collision)
    {
        Collider otherCollider = collision.collider;//�浹�� ����Ų ���
        print($"�浹�� �Ͼ ȣ�� ��ü : {name}, �浹 ��� : {otherCollider.name}");
        //                        �̽�ũ��Ʈ�� �������ִ� ���
    }
    //2. OnCollisionExit : �浹�Ǿ��� �ݶ��̴��� �ٽ� �浹���°� �ƴϰ� �Ǹ� ȣ��
    private void OnCollisionExit(Collision coll)
    {
        print($"�浹�� ���� ȣ�� ��ü : {name}, �浹 ��� : {coll.collider.name}");
    }
    //3. OnCollisionStay : �浹���� �� �����Ӹ��� ȣ��
    private void OnCollisionStay(Collision c)
    {
        print($"�浹�� �Ͼ���� ȣ�� ��ü : {name}, �浹 ��� : {c.collider.name}");
    }

}
