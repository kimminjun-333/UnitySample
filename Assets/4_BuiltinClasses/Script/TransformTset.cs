using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTset : MonoBehaviour
{
    //Transform : ���� ��ü�� ���� ��� GameObject���� ������ 1���� Transform�� ����

    public GameObject yourObject;

    public Transform parent;

    public Transform grandparent;

    private void Start()
    {
        //��� GameObject, Component Ŭ������ transform�̶�� ������Ƽ��
        //�ش� ��ü�� Transform ������Ʈ�� ��ȯ

        print($"my transfrom : {transform}");
        print($"your transfrom : {yourObject.transform}");
        print($"my transfrom's transfrom : {transform.transform}");

        string someChildName = parent.Find("Child 2").GetChild(0).name;
        print(someChildName);

        parent.SetParent(grandparent,false);//�׷�����Ʈ�μ����ϰ� �̵�
        //parent.parent = grandParent; ==> �Ȱ��� �����ϳ� �Ϲ�������SetParent �Լ��� ȣ��

    }


}
