using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoroutineTset : MonoBehaviour
{
    MeshRenderer mr;

    public Material woodMaterial;
    public Material stonMaterial;
    public Material redMaterial;

    public Transform transformTset;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        stonMaterial = mr.material;
    }
    // Start is called before the first frame update
    void Start()
    {
        //��Ȯ�� 3�� �Ŀ� MeshRanderer�� Material�� �ٸ� ���׸���� ��ü �ϰ����
        //var enumerator = stringEnumerator();
        //while(enumerator.MoveNext())
        //{
        //    print(enumerator.Current);
        //}

        //List<int> intList = new List<int>() { 1,2,3 };
        //foreach (int i in intList)
        //{
        //    print(i);
        //}

        //foreach(Transform child in transformTset)
        //{
        //    print(child.name);
        //}

        //Start���� ��������� Update���� ����ѰͰ� �����
        materialChangeCoroutine = StartCoroutine(MaterialChange(redMaterial, 1f));
        //StartCoroutine("MaterialChange");//�Լ�()�� �Էµ������� ""���ڿ� �Էµ� ���������� ������ ����ϴ°� ����


    }
    //�����ʵ�
    private Coroutine materialChangeCoroutine;//���ڿ��ƴҶ��� �����ϳ������ ��ŸƮ�Լ� �ֱ�
    
    // Update is called once per frame
    void Update()
    {
        //if(Time.time > 3f)
        //{
        //    mr.material = woodMaterial;
        //}
        if (Input.GetButtonDown("Jump"))
        {
            mr.material = stonMaterial;
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            print("�ڷ�ƾ ��ž");
            //StopCoroutine(MaterialChange());//�ڷ�ƾ ��ž(���ڿ�)
            StopCoroutine(materialChangeCoroutine);//���ڿ� �ƴҶ��� ��ŸƮ���� ������ �Ű��γ���
        }


    }

    private IEnumerator<string> stringEnumerator()
    {
        //IEnumerator�� ��ȯ�ϴ� �Լ���
        //yield return Ű���带 ����
        //���� ���������� ��ȯ �� �� ����
        yield return "a";
        yield return "b";
        yield return "c";
    }

    private IEnumerator MaterialChange(Material material, float interval)//�Ű������ְ� ��밡��(�ȳ־ ��������)
    {
        //while (true)
        //{
        //    yield return null;
        //    print("MaterialChange �ڷ�ƾ �����");
        //}
        while (true)//3�ʸ��� ���ѹݺ�
        {
            //�ڷ�ƾ�� 3�ʵ��� ����մϴ�
            yield return new WaitForSeconds(interval);//3f�� ���� ���
            mr.material = material;
        }
    }



}
