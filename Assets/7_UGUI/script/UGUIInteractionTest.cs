using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UGUIInteractionTest : MonoBehaviour
{
    //Button ������Ʈ�� OnClick() �̺�Ʈ�� �Ҵ��Ͽ� �ش� ��ư�� Ŭ�� �� ������ ȣ��ǵ���
    //����Ƽ������ Inpector�� �Ҵ�� ��� �������� �������ش�
    //Inspector���� �ش� �Լ��� �����Ϸ��� ���������ڰ� public�̾�� ��
    public void ButtonClick()//�� �Լ��� ��ư�� Ŭ���ɶ� ȣ��
    {
        print("��ư�� Ŭ����");
    }

    public void ButtonClickWithParam(string param)
    {
        print($"��ư Ŭ���� �Ķ���� : {param}");
    }

    public void ButtonClickWithFloatparam(float param)
    {
        print($"��ư Ŭ���� �Ķ���� : {param}");
    }

    public void ButtonClickWithBoolParam(bool param)
    {
        print($"��ư Ŭ���� �Ķ���� : {param}");
    }

}
