using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMessageTest : MonoBehaviour
{
    //물리적인 충돌 또는 상호작용에 의해서 호출되는 메세지
    //OnCollisionXX 메시지 호출 조건 : 호출 될 컴포넌트에 Collider 컴포넌트가 존재해야 하며
    //**메시지 함수를 호출하는 객체가 Rigidbody이므로, 충돌한 두 오브젝트중 하나에는 꼭 Rigidbdy가 붙어 있어야 호출된다


    //1. OnCollisionEnter : 물리적인 충돌이 일어났을때 호출
    private void OnCollisionEnter(Collision collision)
    {
        Collider otherCollider = collision.collider;//충돌을 일으킨 대상
        print($"충돌이 일어남 호출 주체 : {name}, 충돌 대상 : {otherCollider.name}");
        //                        이스크립트를 가지고있는 대상
    }
    //2. OnCollisionExit : 충돌되었던 콜라이더가 다시 충돌상태가 아니게 되면 호출
    private void OnCollisionExit(Collision coll)
    {
        print($"충돌이 종료 호출 주체 : {name}, 충돌 대상 : {coll.collider.name}");
    }
    //3. OnCollisionStay : 충돌중일 때 프레임마다 호출
    private void OnCollisionStay(Collision c)
    {
        print($"충돌이 일어나는중 호출 주체 : {name}, 충돌 대상 : {c.collider.name}");
    }

}
