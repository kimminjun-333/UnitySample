using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFindTast : MonoBehaviour
{
    //������ ���� �Ǳ� �� ������ ���� �� �� �ִ� ������Ʈ�� Inspector���� �Ҵ��Ͽ� ���� �� �� ����
    public GameObject target;
    //�׷��� ������ ���۵Ǳ� ���� ���� �� �� ���ų�, Inspector���� ���� �Ҵ��� �� ���� ��ü��?
    //1.
    private GameObject privateTarget;
    //2.
    private GameObject findedTarget;
    //3.��ü���� find
    private GameObject newTarget;
    private GameObject namedNewTarget;
    private GameObject componentAttachedTarget;


    // Start is called before the first frame update
    void Start()
    {
        //privateTarget�� ã�´�
        //1. ��ü ������ �̸����� Ÿ���� ã�´�
        privateTarget = GameObject.Find("privateTarget");
        //�� ����� ���� ������Ʈ�� �������� ���ϰ� ũ�� �ɸ�
        //���� �̸��� ������Ʈ�� ������ ���� ��� � ������Ʈ�� Ž������ Ȯ���Ҽ� ����
        //�̷� ������ Start() �Լ������� ���������� ����

        //2. ��ü ������ Ư�� ������Ʈ�� ������ �ִ� ��ü�� ã�´�
        //findedTarget = (FindObjectOfType(typeof(FindMe)) as Component).gameObject;
        findedTarget = FindObjectOfType<FindMe>().gameObject;

        //3. �ƿ� ��ü�� ���� �����ϰ�, �ش� ��ü�� ������ �����ص� �ȴ�
        newTarget = new GameObject();//���ӿ�����Ʈ�� �����ڸ� ȣ��
        namedNewTarget = new GameObject("New Taget");
        componentAttachedTarget = new GameObject("component Attached GameObject", typeof(FindMe), typeof(SpriteRenderer));

        //4.Destroy�Լ��� ���� ��ü�� �ƿ� �μ��� �ִ�
        Destroy(privateTarget, 2f);//2���Ŀ� ����
        
        print(findedTarget.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
