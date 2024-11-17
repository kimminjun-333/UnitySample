using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTset : MonoBehaviour
{
    //Transform : 씬에 실체를 가진 모든 GameObject들은 무조건 1개의 Transform을 가짐

    public GameObject yourObject;

    public Transform parent;

    public Transform grandparent;

    private void Start()
    {
        //모든 GameObject, Component 클래스는 transform이라는 프로퍼티로
        //해당 객체의 Transform 컴포넌트를 반환

        print($"my transfrom : {transform}");
        print($"your transfrom : {yourObject.transform}");
        print($"my transfrom's transfrom : {transform.transform}");

        string someChildName = parent.Find("Child 2").GetChild(0).name;
        print(someChildName);

        parent.SetParent(grandparent,false);//그랜드페어런트로설정하고 이동
        //parent.parent = grandParent; ==> 똑같이 동작하나 일반적으로SetParent 함수를 호출

    }


}
