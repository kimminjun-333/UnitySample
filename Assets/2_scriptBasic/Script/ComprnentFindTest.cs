using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprnentFindTest : MonoBehaviour
{
    //게임 오브젝트를 알고있는 상태에서 해당 오브젝트가 가진 컴포넌트를 찾으려 할 경우

    public GameObject target;

    private FindMe findMe;

    // Start is called before the first frame update
    void Start()
    {
        findMe = target.GetComponent<FindMe>();

        print(findMe.message);

        bool isFinded = target.TryGetComponent<BoxCollider>(out BoxCollider boxCollider);
        //성공실패여부 반환                                 out으로 그 결과값을 따로 이름을 만들고 반환

        if (isFinded)
        {
            print($"Box Collider를 찾았습니다 {boxCollider}");
        }
        else
        {
            print($"Box Collider를 찾지 못했습니다 {boxCollider}");
        }

        FindMe[] children = target.GetComponentsInChildren<FindMe>();
        
        foreach ( FindMe child in children )
        {
            print(child.message);
        }

        FindMe newFindMe = target.AddComponent<FindMe>();
        newFindMe.message = "다시 찾음";

        //Destroy 함수를 통해, 게임오브젝트가 아니라 컴포넌트만 삭제할수도 있음
        Destroy(findMe, 2f);//컴포넌트만삭제
        //Destroy(findMe.gameObject, 2f);//오브젝트자체를삭제

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
