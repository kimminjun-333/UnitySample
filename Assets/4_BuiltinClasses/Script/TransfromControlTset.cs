using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransfromControlTset : MonoBehaviour
{
    public Transform target;

    //기본적으로 Transfrom의 position, rotation, localScale 프로퍼티를통해
    //해당 오브젝트의 위치, 각도, 크기등을 제어할 수 있다

    private void Start()
    {
        //ControlByDirection();
        //ControlStraightly();
        //ControlByMethod();

    }

    //값을 직접 대입하여 Transfrom을 제어
    private void ControlStraightly()
    {
        //값을 직접 대입하여 Transtfrom을 제어
        transform.position = new Vector3(3, 2, 1);
        //transform.rotation = new Quaternion(0.3f, 0.02f, 0.001f, 0);
        transform.rotation = Quaternion.Euler(30, 20, 10);//이렇게하면 360도 각도로 조정가능
        print(transform.rotation);
        transform.localScale = new Vector3(4, 5, 6);
    }

    //방향 (좌,우,상,하,전,후)에 방향벡터를 대입하여 Rotation 제어
    private void ControlByDirection()
    {
        Vector3 lookDir = target.position - transform.forward;
        //내위치에서 target 위치로 이동하기 위해 향해야하는 방향 벡터를 구함

        //transform.up = target.position - transform.position;//상대위치 - 내위치 = up방향벡터

        //해당 방향이 나의 right가 되려면?
        //transform.right = target.position - transform.position;
        //transform.right = lookDir;
        //해당 방향이 나의 forward가 되려면
        //transform.forward = target.position - transform.position;
        //transform.right = lookDir;
        //해당 방향이 나의 down이 되려면
        //transform.up = -lookDir;
        //해당 방향이 나의 left가 되려면
        //transform.right = -lookDir;
        //해당 방향이 나의 backwrd가 되려면
        //transform.right = -lookDir;

    }

    private void ControlByMethod()
    {
        //Translate : Position을 제어하는 함수
        transform.Translate(5, 0, 0);
        //Rotate : Totation을 제어하는 함수
        transform.Rotate(30, 0, 0);

        
    }
    //Translate, Rotate 함수를 사용하여 제어하는 것은 : ControlByMethod()
    //transfrom.position, rotation 에 값을 직접 할당하는 것과 비교하자면 : ControlStraightly()
    //현재 position, rotation 기준으로 상대적인 연산이 이루어지는것으로 이해하면 된다



    private void Update()
    {
        //Vector3 lookDir = target.position - transform.forward;
        //transform.up = lookDir; //실시간으로 화면돌아감

        //transform.position = transform.position + new Vector3(3, 2, 1) * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
        //    new Vector3(30, 20, 10) * Time.deltaTime);
        
        transform.Translate(new Vector3(3, 2, 1) * Time.deltaTime);
        transform.Rotate(new Vector3(30, 20, 10) * Time.deltaTime);
        
    }

}
