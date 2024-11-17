using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class BuiltinClassesTest : MonoBehaviour
{
    //����Ƽ �������� �����ϴ� ���̺귯���� ����� Ŭ������ Ȱ��
    //Debug : ����뿡 ���Ǵ� ����� �����ϴ� Ŭ����

    void Start()
    {
        //Debug.Log("Log");
        //Debug.LogWarning("");
        //Debug.LogError("");
        //Debug.LogFormat("{0},{1}",10,5);//XXFormat���� ������ �Լ��� : �Ķ���͸� ���信 ���� ġ���ϴ� ���ڿ�
        //Debug.DrawLine(Vector3.zero, new Vector3(0, 3), Color.cyan, 5f);

        //Mathf : UnityEngine���� �����ϴ� �پ��� ���� ���� �Լ��� ���Ե� Ŭ����
        //Mathf.Abs : ���밪�� ��ȯ
        float a = 0.3f;
        a = Mathf.Abs(a);
        print(a);
        a = Mathf.Abs(+0.3f);
        print(a);

        //(Mathf.Approximately : �ٻ簪 ��, �Ǽ��� �ٻ簪��, ��Ȯ�� �������� �˻��Ҽ� �����Ƿ�
        print(1.1f + 0.1f == 1.2f);
        print(Mathf.Approximately(1.1f + 0.1f, 1.2f));

        //Mathf.Lerp(a,b,t) : ���� ����([L]inear Int[erp]olation) : 
        //a���� b�� ������ t�� ������ŭ�� ��ġ�ϴ� ��(0<t<1)
        print(Mathf.Lerp(-1f, 1f, 0.5f));
        //Lerp(��������)�Լ��� Color, Vector(2,3,4), Quaternion ���� Ŭ�������� ������
        Mathf.InverseLerp(0, 0, 0);//Lerp�� �ݴ� a, b �Ķ���Ͱ� �ݴ�

        //Mathf.Ceil, Floor, Round : �ø�, ����, �ݿø�
        float vul = 5.5f;
        float ceil = Mathf.Ceil(vul);
        float floor = Mathf.Floor(vul);
        float round = Mathf.Round(vul);
        print($"5.5, Ceil : {ceil}, Floor : {floor}, round : {round}");

        //Mathf.Sign();//��ȣ
        //Mathf.Sin();//�ﰢ �Լ� ����
        //Mathf.Pow();//�ŵ�����

        //Random : �������� Ŭ����
        //int�� ��ȯ�ϴ� Range �Լ��� �ִ밪�� �����ϰ� ��ȯ
        int intRandom = Random.Range(-1, 1);//-1,0 �ִ밪 1�� ����
        //float�� ��ȯ�ϴ� Range �Լ��� �ִ밪�� ���ٰ� ���ֵǴ� ���� ��ȯ�� ���� ����
        float floatRandom = Random.Range(-1f, 1f);//�ִ밪 1f�� ���ü�������

        float randomValue = Random.value;//== Random.Range(0f, 1f);����� Ȯ���� ���ϰ� ��� ���� ���

        Vector3 randomPosition = Random.insideUnitSphere * 5f;
        //Vector3(-1 ~ 1, -1 ~ 1, -1 ~ 1); ������ ��ġ�� �̰� ������ ���

        Vector3 randomDirection = Random.onUnitSphere;
        //������ Vector3�� ���µ�, ���̰� �׻� 1, ������ "����"�� �̰� ������ ���
        //Random.rotation;

        Vector3 randomPosition2D = Random.insideUnitCircle;
        //2D�� Random Vector

        //Random.InitState(11234);//������ �õ尪 �ʱ�ȭ
        //���� ���ϰ� ���� �ɸ��� �Լ��̹Ƿ�, ���������� (�� �ε� �ʱ⶧���̳�) ����� ��

        
    }

    //Gizmo : Scene�������� �� �� �ִ� ����� �׸��� Ŭ����(Debug.DrawXX�� Ȯ����ó��)
    //Gizmo Ŭ������ OnDrawGizmos, OnDrawGizmosSelected, OnSceneGUI�� Sceneâ�� �����Ϳ�����
    //Ȱ��ȭ �Ǵ� �޽��� �Լ������� ��ȿ�ϰ� �����
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(Vector3.zero, Mathf.PI);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(Vector3.one, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
