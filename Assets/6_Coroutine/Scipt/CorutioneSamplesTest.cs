using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutioneSamplesTest : MonoBehaviour
{

    
    
    void Start()
    {
        //StartCoroutine(ReturnNull());
        //StartCoroutine(ReturnWaitforSeconds(1f, 5));
        //StartCoroutine(ReturnWaitforSecondsRealtime(1f, 5));
        //StartCoroutine(ReturnUntileWhile());//ex)레버같은거 당기면 아래함수에서 뭔가를 할수있음
        //StartCoroutine(RetrunEndOfFrame());
        StartCoroutine(_1stCoroutine());

        //StartCoroutine을 호출을 하면 코루틴을 핸들링하는 객체가 나 자신이 되므로
        //내 게임 오브젝트가 비활성화 되거나 Compnent가 비활성화 되면
        //내가 StartCoroutine을 통해 생성한 모든 코루틴도 동작을 멈춤

    }

    //yield return null : 매 프레임마다 다음 yield return을 반환
    private IEnumerator ReturnNull()
    {
        print("Return Null 코루틴이 시작되었습니다");
        while (true)
        {
            yield return null;
            print($"Return Null 코루틴이 수행되었습니다 {Time.time}");
        }
    }
    //yield return new WaitForSeconds() : 코루틴이 yield return 키워드를 만나면
    //                                    파라미터만큼 대기 후 수행
    //WaitForSeconds는 TimeScale에 영향을 받는다 %%%%%
    private IEnumerator ReturnWaitforSeconds(float param, int count)
    {
        print("Return Wait for Second 코루틴이 시작되었습니다");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSeconds(param);
            print($"Return Wait for Second {i + 1}번 호출됨 {Time.time}");
        }
        print("Return Wait for Second 코루틴이 끝났습니다");
    }
    //yield return new WaitForSecondsRealtime() :
    //WaitForSeconds 와 동작은 같으나 TimeScale에 영향을 받지 않는다 %%%%%
    private IEnumerator ReturnWaitforSecondsRealtime(float param, int count)
    {
        print("Return Wait for Seconds Realtime 코루틴이 시작되었습니다");
        for (int i = 0; i < count; i++)
        {
            yield return new WaitForSecondsRealtime(param);
            print($"Return Wait for Seconds Realtime {i + 1}번 호출됨 {Time.time}");
        }
        print("Return Wait for Seconds Realtime 코루틴이 끝났습니다");
    }

    public bool continueKey;

    private bool IsContienue()
    {
        return continueKey;
    }


    //yield return new WaitUntil / WaitWhile (param) : 특정 조건이 True/False가 될때까지 대기
    private IEnumerator ReturnUntileWhile()
    {
        print("Return Untile While 코루틴 시작됨");
        while (true)
        {
            //new WaitUntil : 매개변수로 넘어간 함수(대리자(델리게이트))의 return이
            //false인 동안 대기, ture면 넘어감
            yield return new WaitUntil(() => continueKey);//()가 즉석에서 함수를 만들고 그안에 넣음
            print("continueKey가 ture 임");
            //new WaitWhile : 매개변수로 넘어간 함수(대리자(델리게이트))의 return이
            //true인 동안 대기, false면 넘어감
            yield return new WaitWhile(() => continueKey);
            print("continueKey가 false면 임");

        }
    }

    //yield return new (Frame 계열) : 인 게임의 특정 프레임 뒤에 수행됨
    private IEnumerator RetrunEndOfFrame()//Update보다도 늦게 써야할 때 사용
    {
        //EndOfFrame : 해당 프레임의 가장 마지막까지 기다림
        yield return new WaitForEndOfFrame();
    }

    private IEnumerator ReturnFixedUpdate()
    {
        //FixedUpdate : 물리연산이 끝날 때까지 기다림
        yield return new WaitForFixedUpdate();
        print("End of Frame");
        isFirstFrame = false;
    }

    bool isFirstFrame = false;

    //private void Update()
    //{
    //    if(isFirstFrame)
    //    {
    //        print("Update 메시지 함수 호출");
    //    }
    //}

    //private void LateUpdate()
    //{
    //    if(isFirstFrame)
    //    {
    //        print("LateUpdate 메시지 함수 호출");
    //    }
    //}

    //yield return 코루틴 : 해당 코루틴이 끝날때까지 대기
    private IEnumerator _1stCoroutine()
    {
        print("1번째 코루틴이 시작됨");
        for(int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1f);
            print($"1번째 코루틴이 {i + 1}번 수행됨");
        }
        print("1번째 코루틴이 2번째 코루틴을 시작하고 대기함");
        yield return StartCoroutine(_2ndCoroutine());
        print("1번째 코루틴이 종료됨");
    }

    private IEnumerator _2ndCoroutine()
    {
        print("2번째 코루틴 시작됨");
        print("2번째 3번째 코루틴을 시작하고 대기함");
        yield return StartCoroutine(_3ndCoroutine());
        for (int i = 0; i < 5 ; i++)
        {
            print($"2번째 코루틴 {i + 1}번째 수행됨");
            yield return new WaitForSeconds(1f);
        }
        print("2번째 코루틴 종료됨");
    }
    private IEnumerator _3ndCoroutine()
    {
        print("3번째 코루틴 시작됨");
        for (int i = 0;i < 5;i++)
        {
            yield return new WaitForSeconds(1f);
            print($"3번째 코루틴 {i + 1}번째 수행됨");
        }
        print("3번째 코루틴 종료됨");
    }



}
