using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFindTast : MonoBehaviour
{
    //게임이 시작 되기 전 씬에서 참조 할 수 있는 오브젝트는 Inspector에서 할당하여 참조 할 수 있음
    public GameObject target;
    //그런데 게임이 시작되기 전에 참조 할 수 없거나, Inspector에서 값을 할당할 수 없는 객체는?
    //1.
    private GameObject privateTarget;
    //2.
    private GameObject findedTarget;
    //3.객체생성 find
    private GameObject newTarget;
    private GameObject namedNewTarget;
    private GameObject componentAttachedTarget;


    // Start is called before the first frame update
    void Start()
    {
        //privateTarget을 찾는다
        //1. 전체 씬에서 이름으로 타겟을 찾는다
        privateTarget = GameObject.Find("privateTarget");
        //이 방법은 씬에 오브젝트가 많을수록 부하가 크게 걸림
        //같은 이름의 오브젝트가 여러개 있을 경우 어떤 오브젝트가 탐색될지 확신할수 없음
        //이런 이유로 Start() 함수에서만 제한적으로 쓰임

        //2. 전체 씬에서 특정 컴포넌트를 가지고 있는 객체를 찾는다
        //findedTarget = (FindObjectOfType(typeof(FindMe)) as Component).gameObject;
        findedTarget = FindObjectOfType<FindMe>().gameObject;

        //3. 아예 객체를 직접 생성하고, 해당 객체의 참조를 유지해도 된다
        newTarget = new GameObject();//게임오브젝트의 생성자를 호출
        namedNewTarget = new GameObject("New Taget");
        componentAttachedTarget = new GameObject("component Attached GameObject", typeof(FindMe), typeof(SpriteRenderer));

        //4.Destroy함수를 통해 객체를 아예 부술수 있다
        Destroy(privateTarget, 2f);//2초후에 삭제
        
        print(findedTarget.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
