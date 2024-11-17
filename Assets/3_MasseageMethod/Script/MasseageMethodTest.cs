using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasseageMethodTest : MonoBehaviour
{
    //�޼��� �Լ�(�̺�Ʈ �Լ�) : �����ڰ� ���� ȣ������ �ʾƵ� ����Ƽ ���� ���μ����� �߻��ϴ� �̺�Ʈ������
    //����Ƽ ������ ȣ�� ���ִ� �Լ�
    //�Լ� �̸��� ������ ������, �Լ� �������� ȣ�������� �ٸ���

    private BoxCollider boxCollider;
    //0. Awake() �Լ� : ��ü�� �ε���ڸ��� ȣ��
    //���� : �ش� GameObject ���� �ٸ� ������Ʈ�� ���� ����������, �ٸ� GameObject�� ���� �ε尡 �ȵǾ
    //������ �Ұ��� �� ���ɼ��� ����
    //�׷��Ƿ� �� ������Ʈ�� ������ GameObject�� �ʱ�ȭ �� �뵵�� ���
    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();

        if(transform.position.y > 1)
        {
            boxCollider.center = new Vector3(0, -1, 0);
        }
    }

    //1. Start() �Լ� : ������ �ε�� �� ���� ù ������ ���� ������ ȣ��
    private string state = "�غ� �ȵ�";
    private bool isInit = false;
    private void Start()//���������� �����, �̸��� Start�� ��
    {
        print("Start �޽��� �Լ� ȣ��");
        state = "�غ� ��";
        isInit = true;
    }

    int frameCount = 0;
    //2. Update() �Լ� : ������ �ε�� �� �� �����Ӹ��� �ѹ��� ȣ��
    private void Update()
    {
        //print($"Update �޽��� �Լ� ȣ�� {frameCount++}");
    }

    //4. OnEnable/OnDisable : �ش� ��ü �Ǵ� ������Ʈ�� Ȱ��ȭ �ǰų� ��Ȱ��ȭ �Ǹ� ȣ��
    //���� : OnEnable�� ��ü �ε尡 �Ϸ�� �Ŀ� ��� ȣ��ǹǷ�, ó�� 1ȸ�� Start���� ���� ȣ���
    //�� ����� �� : �� ������Ʈ�� �ʱ�ȭ ���࿩�θ� üũ ���ָ� ����
    private void OnEnable()
    {
        if (false == isInit) return;
        print($"OnEnable �Լ� ȣ��");
        print($"���� ��ü ���� : {state}");
    }
    private void OnDisable()
    {
        print($"OnDisable �Լ� ȣ��");
    }

    //4. OnDestroy : ���� ������Ʈ �Ǵ� ������Ʈ�� �ı��� �� ȣ��
    //���� : ȣ��Ǳ� ���� OnDisable() �Լ��� ���� ȣ��
    private void OnDestroy()
    {
        print($"OnDestroy �Լ� ȣ��");
    }

}
