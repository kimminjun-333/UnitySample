using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutioneStarter : MonoBehaviour
{

    public CoroutineTarget target;

    private void Start()
    {
        //StartCoroutine�� ȣ���� �ϸ� �ڷ�ƾ�� �ڵ鸵�ϴ� ��ü�� �� �ڽ��� �ǹǷ�
        //�� ���� ������Ʈ�� ��Ȱ��ȭ �ǰų� Compnent�� ��Ȱ��ȭ �Ǹ�
        //���� StartCoroutine�� ���� ������ ��� �ڷ�ƾ�� ������ ����
        target.StartCoroutine(DamegeOnTime());
    }
    private IEnumerator DamegeOnTime()
    {
        print($"{name}�� {target.name}���� ��Ʈ �������� �־����ϴ�");

        for ( int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1f);
            print($"{target.name} : �ƾ�! x {i}");
        }

    }

}
