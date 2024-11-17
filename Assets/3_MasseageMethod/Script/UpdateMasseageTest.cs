using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMasseageTest : MonoBehaviour
{
    private float preFrameTime = 0;//���� �������� ȣ��� �ð�

    //1. Update : �� �������� ���� ó�� ȣ��
    private void Update()
    {
        //Time.time : ������ ���۵� �ڷ� 1�ʴ� 1f�� �ӵ��� ����
        print($"Update ȣ���, ȣ��ð� : {Time.time}, ���� �����Ӱ� �ð����� : {Time.time - preFrameTime}");
        preFrameTime = Time.time;
        print($"deltaTime : {Time.deltaTime}");
    }

    //2. FixdeUpdate : ���� ������ �����Ӱ� ������ ���������� ����� ������ ȣ��, ȣ���ֱⰡ ������
    private float porPhysicsFrameTime = 0;
    private void FixedUpdate()
    {
        print($"FixedUpdate ȣ���, ȣ��ð� : {Time.time}, ���� �����Ӱ� �ð����� : {Time.time - porPhysicsFrameTime}");
        porPhysicsFrameTime = Time.time;
        print($"FixedDeltaTime : {Time.fixedDeltaTime}");
    }

    //3. LateUpdate : �� �������� ���� ���߿� ȣ��, ���� �����ӿ��� ȣ��ǹǷ� Update�� ȣ�������
    //�ٸ����� �ð����̴� ũ�� ����
    private float preFrameLateTime = 0;
    private void LateUpdate()
    {
        print($"LateUpdate ȣ���, ȣ��ð� : {Time.time}, ���� �����Ӱ� �ð����� : {Time.time - preFrameLateTime}");
        preFrameLateTime = Time.time;
    }

}
