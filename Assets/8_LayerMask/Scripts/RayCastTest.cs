using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class RayCastTest : MonoBehaviour
    {
        //��Ʈ �÷���
        //00000000 : noting
        //00000001 : Default        1 << 0
        //00000010 : TransparentFX  1 << 1
        //00001000 : Ignore Physics 1 << 3 (1�� ������ 3����Ʈ��ŭ �̵����Ѷ�)
        //00001001 : Default, Ignore Physics�� ���� ���� : 8 + 1 = 9
        public LayerMask CustomMask;

        private void Start()
        {
            print($"Default Latyer : {LayerMask.NameToLayer("Default")}");
            print($"TransparentFX Latyer : {LayerMask.NameToLayer("TransparentFX")}");
            print($"Ignore Physics Latyer : {LayerMask.NameToLayer("Ignore Physics")}");
            print($"Custom Latet Mask : {CustomMask.value}");

        }
        
        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //Camera.ScreenPointToRay : �ش� ī�޶� �������� ��ũ���� ���콺 ��ġ����
                //                          ī�޶� ���� �������� ���̸� ����
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                //Physics.Raycast �Լ� ȣ���,Layer Mask�� �Ķ���ͷ� ������� ������
                //�ڵ����� Ignore Raycast ���̾�� ������

                if (Physics.Raycast(ray, out RaycastHit hit, 1000f,
                    1<<LayerMask.NameToLayer("Ignore Physics")))
                { 
                    hit.collider.GetComponentInParent<Renderer>().material.color 
                        = Color.red;
                    print(hit.collider.name);
                }

            }
        }


    }
}
