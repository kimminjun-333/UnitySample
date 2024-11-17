using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutioneSamplesTest : MonoBehaviour
{

    
    
    void Start()
    {
        //StartCoroutine(ReturnNull());
        //StartCoroutine(ReturnWaitforSeconds(1f, 5));
        //StartCoroutine(ReturnWaitforSecondsRealtime(1f, 5));
        //StartCoroutine(ReturnUntileWhile());//ex)���������� ���� �Ʒ��Լ����� ������ �Ҽ�����
        //StartCoroutine(RetrunEndOfFrame());
        StartCoroutine(_1stCoroutine());

        //StartCoroutine�� ȣ���� �ϸ� �ڷ�ƾ�� �ڵ鸵�ϴ� ��ü�� �� �ڽ��� �ǹǷ�
        //�� ���� ������Ʈ�� ��Ȱ��ȭ �ǰų� Compnent�� ��Ȱ��ȭ �Ǹ�
        //���� StartCoroutine�� ���� ������ ��� �ڷ�ƾ�� ������ ����

    }

    //yield return null : �� �����Ӹ��� ���� yield return�� ��ȯ
    private IEnumerator ReturnNull()
    {
        print("Return Null �ڷ�ƾ�� ���۵Ǿ����ϴ�");
        while (true)
        {
            yield return null;
            print($"Return Null �ڷ�ƾ�� ����Ǿ����ϴ� {Time.time}");
        }
    }
    //yield return new WaitForSeconds() : �ڷ�ƾ�� yield return Ű���带 ������
    //                                    �Ķ���͸�ŭ ��� �� ����
    //WaitForSeconds�� TimeScale�� ������ �޴´� %%%%%
    private IEnumerator ReturnWaitforSeconds(float param, int count)
    {
        print("Return Wait for Second �ڷ�ƾ�� ���۵Ǿ����ϴ�");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSeconds(param);
            print($"Return Wait for Second {i + 1}�� ȣ��� {Time.time}");
        }
        print("Return Wait for Second �ڷ�ƾ�� �������ϴ�");
    }
    //yield return new WaitForSecondsRealtime() :
    //WaitForSeconds �� ������ ������ TimeScale�� ������ ���� �ʴ´� %%%%%
    private IEnumerator ReturnWaitforSecondsRealtime(float param, int count)
    {
        print("Return Wait for Seconds Realtime �ڷ�ƾ�� ���۵Ǿ����ϴ�");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSecondsRealtime(param);
            print($"Return Wait for Seconds Realtime {i + 1}�� ȣ��� {Time.time}");
        }
        print("Return Wait for Seconds Realtime �ڷ�ƾ�� �������ϴ�");
    }

    public bool continueKey;

    private bool IsContienue()
    {
        return continueKey;
    }


    //yield return new WaitUntil / WaitWhile (param) : Ư�� ������ True/False�� �ɶ����� ���
    private IEnumerator ReturnUntileWhile()
    {
        print("Return Untile While �ڷ�ƾ ���۵�");
        while (true)
        {
            //new WaitUntil : �Ű������� �Ѿ �Լ�(�븮��(��������Ʈ))�� return��
            //false�� ���� ���, ture�� �Ѿ
            yield return new WaitUntil(() => continueKey);//()�� �Ｎ���� �Լ��� ����� �׾ȿ� ����
            print("continueKey�� ture ��");
            //new WaitWhile : �Ű������� �Ѿ �Լ�(�븮��(��������Ʈ))�� return��
            //true�� ���� ���, false�� �Ѿ
            yield return new WaitWhile(() => continueKey);
            print("continueKey�� false�� ��");

        }
    }

    //yield return new (Frame �迭) : �� ������ Ư�� ������ �ڿ� �����
    private IEnumerator RetrunEndOfFrame()//Update���ٵ� �ʰ� ����� �� ���
    {
        //EndOfFrame : �ش� �������� ���� ���������� ��ٸ�
        yield return new WaitForEndOfFrame();
    }

    private IEnumerator ReturnFixedUpdate()
    {
        //FixedUpdate : ���������� ���� ������ ��ٸ�
        yield return new WaitForFixedUpdate();
        print("End of Frame");
        isFirstFrame = false;
    }

    bool isFirstFrame = false;

    //private void Update()
    //{
    //    if(isFirstFrame)
    //    {
    //        print("Update �޽��� �Լ� ȣ��");
    //    }
    //}

    //private void LateUpdate()
    //{
    //    if(isFirstFrame)
    //    {
    //        print("LateUpdate �޽��� �Լ� ȣ��");
    //    }
    //}

    //yield return �ڷ�ƾ : �ش� �ڷ�ƾ�� ���������� ���
    private IEnumerator _1stCoroutine()
    {
        print("1��° �ڷ�ƾ�� ���۵�");
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1f);
            print($"1��° �ڷ�ƾ�� {i + 1}�� �����");
        }
        print("1��° �ڷ�ƾ�� 2��° �ڷ�ƾ�� �����ϰ� �����");
        yield return StartCoroutine(_2ndCoroutine());
        print("1��° �ڷ�ƾ�� �����");
    }

    private IEnumerator _2ndCoroutine()
    {
        print("2��° �ڷ�ƾ ���۵�");
        print("2��° 3��° �ڷ�ƾ�� �����ϰ� �����");
        yield return StartCoroutine(_3ndCoroutine());
        for (int i = 0; i < 5 ; i++)
        {
            print($"2��° �ڷ�ƾ {i + 1}��° �����");
            yield return new WaitForSeconds(1f);
        }
        print("2��° �ڷ�ƾ �����");
    }
    private IEnumerator _3ndCoroutine()
    {
        print("3��° �ڷ�ƾ ���۵�");
        for (int i = 0;i < 5;i++)
        {
            yield return new WaitForSeconds(1f);
            print($"3��° �ڷ�ƾ {i + 1}��° �����");
        }
        print("3��° �ڷ�ƾ �����");
    }



}
