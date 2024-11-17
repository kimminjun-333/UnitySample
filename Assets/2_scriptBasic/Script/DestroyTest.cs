using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTest : MonoBehaviour
{
    public GameObject destroyTarget;
    public Component destroyComponentTarget;
    public GameObject destroyTargetWithDelay;
    public GameObject destroyTargetOnImmediately;

    //��ü�� �����ϴ� 4���� ���

    // Start is called before the first frame update
    void Start()
    {
        //1. GameObject�� Destroy(�ı�)�Ѵ�
        Destroy(destroyTarget);

        //2. Component�� ����� Object�� �ı��Ѵ�
        Destroy(destroyComponentTarget);
        //Destroy �Լ��� ȣ�� ���Ŀ��� �Ķ���ͷ� ������ ������Ʈ�� ������ ����.(��ü�� ���� �ı����� �ʴ´�)
        FindMe findMe = destroyComponentTarget as FindMe;
        print(findMe.message);
        //Destroy �Լ��� �Ķ���ͷ� ���޵� ������Ʈ�� ��� �ı� �Ǵ°��� �ƴ�, �ı� �� ��Ʈ�� ����Ʈ �� �� �Ŀ�
        //���� �������� ���۵Ǳ� ���� �ı���. ���� �ش� �����ӿ��� ���� ��ü�� �����ϴ� ��

        //3. �׷��� ������, Destroy �Լ��� �����̸� ���� �ϴ°��� �����ϴ�
        Destroy(destroyTargetWithDelay, 3f);

        //4. ����, ���� �������̶� Ư�� ��ü�� ��� �ı��Ǳ⸦ ���Ѵٸ� DestroyImmediate() �Լ��� ����Ұ�
        DestroyImmediate(destroyTargetOnImmediately);
        //�� �Լ��� ȣ��� ���� �ڵ���ο����� �ش� ��ü�� ���� �� �� ����
        //�� �Ե� ���� ���ϰ� �ٷ� �ı�
        //print(destroyTargetOnImmediately.name); // <- ���� Ȯ��

        //��� 
        //Destroy : �����̼��������� ����
        //DestroyImmediate : ��û���

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
