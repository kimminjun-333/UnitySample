using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpielMouseControl : MonoBehaviour
{
    private void Start()
    {
        //���콺 Ŀ�� ȭ�鿡 ���
        //Locked : ȭ�� �߾ӿ� ���
        //Confined : ȭ�� �׵θ� �ȿ� ����
        //None : �����
        //Cursor.lockState = CursorLockMode.Locked;
        //Ŀ�� ���̴� ����, Editor�� ��쿡 ���� ���� ���ص� Esc Ű�� ������ ���콺�� ����
        //Cursor.visible = false;
        OnApplicationFocus(true);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            OnApplicationFocus(false);
        }
        else if(Input.anyKeyDown)
        {
            OnApplicationFocus(true);
        }
    }

    public static bool isFocusing = true;
    //�޽����Լ�
    private void OnApplicationFocus(bool focus)
    {
        isFocusing = focus;

        if(isFocusing)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

}
