using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoroutineTset : MonoBehaviour
{
    MeshRenderer mr;

    public Material woodMaterial;
    public Material stonMaterial;
    public Material redMaterial;

    public Transform transformTset;

    private void Awake()
    {
        mr = GetComponent<MeshRenderer>();
        stonMaterial = mr.material;
    }
    // Start is called before the first frame update
    void Start()
    {
        //정확히 3초 후에 MeshRanderer의 Material을 다른 마테리얼로 교체 하고싶음
        //var enumerator = stringEnumerator();
        //while(enumerator.MoveNext())
        //{
        //    print(enumerator.Current);
        //}

        //List<int> intList = new List<int>() { 1,2,3 };
        //foreach (int i in intList)
        //{
        //    print(i);
        //}

        //foreach(Transform child in transformTset)
        //{
        //    print(child.name);
        //}

        //Start에서 수행되지만 Update에서 사용한것과 비슷함
        materialChangeCoroutine = StartCoroutine(MaterialChange(redMaterial, 1f));
        //StartCoroutine("MaterialChange");//함수()로 입력도되지만 ""문자열 입력도 가능하지만 위에로 사용하는게 좋음


    }
    //전역필드
    private Coroutine materialChangeCoroutine;//문자열아닐때는 변수하나만들고 스타트함수 넣기
    
    // Update is called once per frame
    void Update()
    {
        //if(Time.time > 3f)
        //{
        //    mr.material = woodMaterial;
        //}
        if (Input.GetButtonDown("Jump"))
        {
            mr.material = stonMaterial;
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            print("코루틴 스탑");
            //StopCoroutine(MaterialChange());//코루틴 스탑(문자열)
            StopCoroutine(materialChangeCoroutine);//문자열 아닐때는 스타트넣은 변수를 매개로넣음
        }


    }

    private IEnumerator<string> stringEnumerator()
    {
        //IEnumerator를 반환하는 함수는
        //yield return 키워드를 통해
        //값을 순차적으로 반환 할 수 있음
        yield return "a";
        yield return "b";
        yield return "c";
    }

    private IEnumerator MaterialChange(Material material, float interval)//매개변수넣고 사용가능(안넣어도 가능은함)
    {
        //while (true)
        //{
        //    yield return null;
        //    print("MaterialChange 코루틴 수행됨");
        //}
        while (true)//3초마다 무한반복
        {
            //코루틴이 3초동안 대기합니다
            yield return new WaitForSeconds(interval);//3f초 동안 대기
            mr.material = material;
        }
    }



}
