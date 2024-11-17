using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class BuiltinClassesTest : MonoBehaviour
{
    //유니티 엔진에서 제공하는 라이브러리에 내장된 클래스를 활용
    //Debug : 디버깅에 사용되는 기능을 제공하는 클래스

    void Start()
    {
        //Debug.Log("Log");
        //Debug.LogWarning("");
        //Debug.LogError("");
        //Debug.LogFormat("{0},{1}",10,5);//XXFormat으로 끝나는 함수들 : 파라미터를 포멧에 따라 치완하는 문자열
        //Debug.DrawLine(Vector3.zero, new Vector3(0, 3), Color.cyan, 5f);

        //Mathf : UnityEngine에서 제공하는 다양한 수학 연산 함수가 포함된 클래스
        //Mathf.Abs : 절대값을 반환
        float a = 0.3f;
        a = Mathf.Abs(a);
        print(a);
        a = Mathf.Abs(+0.3f);
        print(a);

        //(Mathf.Approximately : 근사값 비교, 실수의 근사값비교, 정확히 같은지를 검사할수 없으므로
        print(1.1f + 0.1f == 1.2f);
        print(Mathf.Approximately(1.1f + 0.1f, 1.2f));

        //Mathf.Lerp(a,b,t) : 선형 보간([L]inear Int[erp]olation) : 
        //a값과 b값 사이의 t의 비율만큼에 위치하는 값(0<t<1)
        print(Mathf.Lerp(-1f, 1f, 0.5f));
        //Lerp(선형보간)함수는 Color, Vector(2,3,4), Quaternion 등의 클래스에도 존재함
        Mathf.InverseLerp(0, 0, 0);//Lerp의 반대 a, b 파라미터가 반대

        //Mathf.Ceil, Floor, Round : 올림, 내림, 반올림
        float vul = 5.5f;
        float ceil = Mathf.Ceil(vul);
        float floor = Mathf.Floor(vul);
        float round = Mathf.Round(vul);
        print($"5.5, Ceil : {ceil}, Floor : {floor}, round : {round}");

        //Mathf.Sign();//부호
        //Mathf.Sin();//삼각 함수 사인
        //Mathf.Pow();//거듭제곱

        //Random : 난수생성 클래스
        //int를 반환하는 Range 함수는 최대값은 제외하고 반환
        int intRandom = Random.Range(-1, 1);//-1,0 최대값 1은 제외
        //float를 반환하는 Range 함수는 최대값과 같다고 간주되는 값이 반환될 수도 있음
        float floatRandom = Random.Range(-1f, 1f);//최대값 1f도 나올수도있음

        float randomValue = Random.value;//== Random.Range(0f, 1f);백분율 확률을 편하게 얻기 위해 사용

        Vector3 randomPosition = Random.insideUnitSphere * 5f;
        //Vector3(-1 ~ 1, -1 ~ 1, -1 ~ 1); 랜덤한 위치를 뽑고 싶을때 사용

        Vector3 randomDirection = Random.onUnitSphere;
        //랜덤한 Vector3가 오는데, 길이가 항상 1, 랜덤한 "방향"을 뽑고 싶을때 사용
        //Random.rotation;

        Vector3 randomPosition2D = Random.insideUnitCircle;
        //2D용 Random Vector

        //Random.InitState(11234);//난수의 시드값 초기화
        //연산 부하가 많이 걸리는 함수이므로, 제한적으로 (씬 로딩 초기때쯤이나) 사용할 것

        
    }

    //Gizmo : Scene차에서만 볼 수 있는 기즈모를 그리는 클래스(Debug.DrawXX의 확장기능처럼)
    //Gizmo 클래스는 OnDrawGizmos, OnDrawGizmosSelected, OnSceneGUI등 Scene창과 에디터에서만
    //활성화 되는 메시지 함수에서만 유효하게 기능함
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(Vector3.zero, Mathf.PI);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(Vector3.one, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
