using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutioneStarter : MonoBehaviour
{

    public CoroutineTarget target;

    private void Start()
    {
        //StartCoroutine을 호출을 하면 코루틴을 핸들링하는 객체가 나 자신이 되므로
        //내 게임 오브젝트가 비활성화 되거나 Compnent가 비활성화 되면
        //내가 StartCoroutine을 통해 생성한 모든 코루틴도 동작을 멈춤
        target.StartCoroutine(DamegeOnTime());
    }
    private IEnumerator DamegeOnTime()
    {
        print($"{name}이 {target.name}에게 도트 데미지를 주었습니다");

        for ( int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1f);
            print($"{target.name} : 아야! x {i}");
        }

    }

}
