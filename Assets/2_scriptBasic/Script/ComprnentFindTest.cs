using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprnentFindTest : MonoBehaviour
{
    //���� ������Ʈ�� �˰��ִ� ���¿��� �ش� ������Ʈ�� ���� ������Ʈ�� ã���� �� ���

    public GameObject target;

    private FindMe findMe;

    // Start is called before the first frame update
    void Start()
    {
        findMe = target.GetComponent<FindMe>();

        print(findMe.message);

        bool isFinded = target.TryGetComponent<BoxCollider>(out BoxCollider boxCollider);
        //�������п��� ��ȯ                                 out���� �� ������� ���� �̸��� ����� ��ȯ

        if (isFinded)
        {
            print($"Box Collider�� ã�ҽ��ϴ� {boxCollider}");
        }
        else
        {
            print($"Box Collider�� ã�� ���߽��ϴ� {boxCollider}");
        }

        FindMe[] children = target.GetComponentsInChildren<FindMe>();
        
        foreach ( FindMe child in children )
        {
            print(child.message);
        }

        FindMe newFindMe = target.AddComponent<FindMe>();
        newFindMe.message = "�ٽ� ã��";

        //Destroy �Լ��� ����, ���ӿ�����Ʈ�� �ƴ϶� ������Ʈ�� �����Ҽ��� ����
        Destroy(findMe, 2f);//������Ʈ������
        //Destroy(findMe.gameObject, 2f);//������Ʈ��ü������

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
