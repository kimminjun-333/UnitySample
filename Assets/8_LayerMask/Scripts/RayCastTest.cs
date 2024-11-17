using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyProject
{
    public class RayCastTest : MonoBehaviour
    {
        //비트 플래그
        //00000000 : noting
        //00000001 : Default        1 << 0
        //00000010 : TransparentFX  1 << 1
        //00001000 : Ignore Physics 1 << 3 (1을 옆으로 3개비트만큼 이동시켜라)
        //00001001 : Default, Ignore Physics를 같이 쓸때 : 8 + 1 = 9
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
                //Camera.ScreenPointToRay : 해당 카메라 시점에서 스크린의 마우스 위치에서
                //                          카메라가 보는 방향으로 레이를 생성
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                //Physics.Raycast 함수 호출시,Layer Mask를 파라미터로 명시하지 않으면
                //자동으로 Ignore Raycast 레이어는 무시함

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
