using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateTest : MonoBehaviour
{

    public GameObject original;

    void Start()
    {
        //original ��ü�� �Ȱ��� ���� ������Ʈ�� �ϳ� �� ����� ���� ��ġ�ϰ� ������
        //GameObject clone = new GameObject("Clone");


        //MeshFilter mf = clone.AddComponent<MeshFilter>();
        //MeshRenderer mr = clone.AddComponent<MeshRenderer>();

        // mf.mesh = original.GetComponent<MeshFilter>().mesh;
        // mr.material = original.GetComponent<MeshRenderer>().material;

        // clone.transform.position = original.transform.position + Vector3.right;
        //�̷� ���� ���ϰ� �̷��� ��-��

        //Instantiate(original).transform.position = original.transform.position + Vector3.right;
        //Instantiate : �Ķ���� ��ü�� �Ȱ��� �����ϴ� �Լ�
        //����� ���ÿ� Hierachy �󿡼� Ư�� ��ü�� �ڽ��� �Ǿ�� �� ���
        //Instantiate(original, transform);
        //����� ���ÿ� Ư�� ��ġ�� Ư�� ���� ������ �����Ǿ�� �Ұ��
        //Instantiate(original, Vector3.right, Quaternion.identity);//������1ĭ, �������� ����
        //Instantiate �Լ��� �Ķ���͸� ���� ������ ��ü�� Return��

        //���� ��ü ��������
        GameObject clone = Instantiate(original, Vector3.right, Quaternion.identity);
        clone.name = "this is clone";
        //clone.GetComponent<MeshRenderer>().material.color = Color.gray;

    }

    
}
